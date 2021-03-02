using System.IO;
using System.IO.Compression;

namespace FirstPass {

    /// <summary>
    /// Contains all the methods for file compression and decompression.
    /// </summary>
    public static class Compressor {

        /// <summary>
        /// Compresses a file using GZip compression.
        /// </summary>
        /// <param name="inFile">Filepath of the file to be compressed.</param>
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

            // Delete uncompressed file
            File.Delete(inFile);

            // Updates the file
            FileOP.LoadFile(FileOP.GetFile() + ".gz");
        }

        /// <summary>
        /// Decompresses a file using GZip decompression.
        /// </summary>
        /// <param name="inFile">Filepath of the file to be decompressed.</param>
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

                // Updates FileOP to the decompressed file
                FileOP.LoadFile(FileOP.GetFile().Remove(FileOP.GetFile().Length - fileToDecompress.Extension.Length));
            }

            // Delete compressed file
            File.Delete(inFile);
        }
    }
}
