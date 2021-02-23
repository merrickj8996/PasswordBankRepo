using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1 {

    public static class Compressor {

        // Compresses all files in a folder using GZip
        public static void Compress(string inFile) {
            //Makes new FileInfo for the target file
            FileInfo fileToCompress = new FileInfo(inFile);

            // Creates a File Stream containing the data in the fileToCompress
            using (FileStream originalFileStream = fileToCompress.OpenRead()) {

                // Check that the file is not hidden or already a .gz file
                if ((File.GetAttributes(fileToCompress.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & fileToCompress.Extension != ".gz") {

                    // Creates a File Stream for the compressed file
                    using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz")) {

                        // Creates the compression stream
                        using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress)) {

                            // Compresses file
                            originalFileStream.CopyTo(compressionStream);
                        }
                    }
                }
            }

            //Delete uncompressed file
            File.Delete(inFile);
            FileOP.LoadFile(FileOP.GetFile() + ".gz");
        }

        // Decompresses a file using GZip
        public static void Decompress(string inFile) {

            //Makes new FileInfo for the target file
            FileInfo fileToDecompress = new FileInfo(inFile);

            // Creates a FileStream containing the data from fileToDecompress
            using (FileStream originalFileStream = fileToDecompress.OpenRead()) {

                string currentFileName = fileToDecompress.FullName;
                string newFileName = currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length);

                // Creates the decompressed file stream
                using (FileStream decompressedFileStream = File.Create(newFileName)) {

                    // Creates the compression stream
                    using (GZipStream decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress)) {

                        // Decompresses file
                        decompressionStream.CopyTo(decompressedFileStream);
                    }
                }
                FileOP.LoadFile(FileOP.GetFile().Remove(FileOP.GetFile().Length - fileToDecompress.Extension.Length));
            }

            // Delete compressed file
            File.Delete(inFile);

        }
    }
}
