using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPass {
    class StegImportExport {
        public enum State { Hiding, Filling_With_Zeros };

        public static Bitmap embedText(string text, Bitmap bmp) {
            State state = State.Hiding; // initially, we'll be hiding characters in the image

            int charIndex = 0; // holds the index of the character that is being hidden
            int charValue = 0; // holds the value of the character converted to integer
            long pixelElementIndex = 0; // holds the index of the color element (R or G or B) that is currently being processed
            int zeros = 0; // holds the number of trailing zeros that have been added when finishing the process
            int R = 0, G = 0, B = 0; // hold pixel elements

            for (int i = 0; i < bmp.Height; i++) {
                for (int j = 0; j < bmp.Width; j++) {
                    Color pixel = bmp.GetPixel(j, i); // holds the pixel that is currently being processed

                    // now, clear the least significant bit (LSB) from each pixel element
                    R = pixel.R - pixel.R % 2;
                    G = pixel.G - pixel.G % 2;
                    B = pixel.B - pixel.B % 2;

                
                    for (int n = 0; n < 3; n++) { // for each pixel, pass through its elements (RGB)
                        if (pixelElementIndex % 8 == 0) { // check if new 8 bits has been processed
                            if (state == State.Filling_With_Zeros && zeros == 8) { // check if the whole process has finished - we can say that it's finished when 8 zeros are added
                                if ((pixelElementIndex - 1) % 3 < 2) { // apply the last pixel on the image even if only a part of its elements have been affected
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }
                                return bmp; // return the bitmap with the text hidden in
                            }

                        
                            if (charIndex >= text.Length) { // check if all characters has been hidden
                                state = State.Filling_With_Zeros; // start adding zeros to mark the end of the text
                            }
                            else {
                                charValue = text[charIndex++]; // move to the next character and process again
                            }
                        }

                    // check which pixel element has the turn to hide a bit in its LSB
                        switch (pixelElementIndex % 3) {
                            case 0:
                                {
                                    if (state == State.Hiding) {
                                        R += charValue % 2; // the rightmost bit in the character will be (charValue % 2) to put this value instead of the LSB of the pixel element
                                        charValue /= 2; // removes the added rightmost bit of the character such that next time we can reach the next one
                                    }
                                } break;
                            case 1:
                                {
                                    if (state == State.Hiding) {
                                        G += charValue % 2;
                                        charValue /= 2;
                                    }
                                } break;
                            case 2:
                                {
                                    if (state == State.Hiding) {
                                        B += charValue % 2;
                                        charValue /= 2;
                                    }
                                    bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                } break;
                        }

                        pixelElementIndex++;

                        if (state == State.Filling_With_Zeros) {
                            // increment the value of zeros until it is 8
                            zeros++;
                        }
                    }
                }
            }
            return bmp;
        }

        public static string extractText(Bitmap bmp) {
            int colorUnitIndex = 0;
            int charValue = 0;
            string extractedText = ""; // holds the text that will be extracted from the image

        
            for (int i = 0; i < bmp.Height; i++) { // pass through the rows
                for (int j = 0; j < bmp.Width; j++) { // pass through each column in the row
                    Color pixel = bmp.GetPixel(j, i);

                    for (int n = 0; n < 3; n++) { // for each pixel, pass through its elements (RGB)
                        switch (colorUnitIndex % 3) {
                            case 0:
                            {
                                // get the LSB from the pixel element (will be pixel.R % 2) then add one bit to the right of the current character
                                // replace the added bit (which value is by default 0) with the LSB of the pixel element by adding
                                charValue = charValue * 2 + pixel.R % 2;
                            } break;
                            case 1:
                            {
                                charValue = charValue * 2 + pixel.G % 2;
                            } break;
                            case 2:
                            {
                                charValue = charValue * 2 + pixel.B % 2;
                            } break;
                        }   

                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0) { // if 8 bits has been added, then add the current character to the result text
                            charValue = reverseBits(charValue);

                            if (charValue == 0) { // can only be 0 if it is the stop character (the 8 zeros)
                                return extractedText;
                            }

                            char c = (char)charValue; // convert the character value from int to char
                            extractedText += c.ToString(); // add the current character to the result text
                        }
                    }
                }
            }
        return extractedText;
        }

        public static int reverseBits(int n) {
            int result = 0;

            for (int i = 0; i < 8; i++) {
                result = result * 2 + n % 2;
                n /= 2;
            }
            return result;
        }
    }
}
