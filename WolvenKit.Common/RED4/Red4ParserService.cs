using System;
using System.IO;
using System.Text;
using WolvenKit.Common.Model;
using WolvenKit.Common.RED4.Compiled;
using WolvenKit.Common.Services;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.RED4.CR2W
{
    public class Red4ParserService : IRedParserService
    {
        private readonly IHashService _hashService;

        public Red4ParserService(IHashService hashService)
        {
            _hashService = hashService;
        }


        #region Methods

        /// <summary>
        /// Try reading a cr2w file from a stream, returns null if unsuccesful
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public CR2WFile TryReadRED4File(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadRED4File(br);
        }

        public CR2WFile TryReadRED4File(BinaryReader br)
        {
            // peak if cr2w
            if (br.BaseStream.Length < 4)
            {
                return null;
            }

            br.BaseStream.Seek(0, SeekOrigin.Begin);
            var magic = br.ReadUInt32();
            var isCr2wFile = magic == CR2WFile.MAGIC;
            if (!isCr2wFile)
            {
                return null;
            }

            var cr2w = new CR2WFile();
            try
            {
                //TODO: verify cr2w integrity
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                cr2w.Read(br);
            }
            catch (MissingRTTIException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

            return cr2w;
        }

        /// <summary>
        /// Try reading the cr2w file headers only from a stream, returns null if unsuccesful
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public CR2WFile TryReadRED4FileHeaders(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadRED4FileHeaders(br);
        }

        public CR2WFile TryReadRED4FileHeaders(BinaryReader br)
        {
            // peak if cr2w
            if (br.BaseStream.Length < 4)
                return null;
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            var magic = br.ReadUInt32();
            var isCr2wFile = magic == CR2WFile.MAGIC;
            if (!isCr2wFile)
                return null;

            var cr2w = new CR2WFile();
            try
            {
                //TODO: verify cr2w integrity
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                cr2w.ReadHeaders(br);
            }
            catch (Exception)
            {
                return null;
            }

            return cr2w;
        }

        public CompiledPackage TryReadCompiledPackage(Stream stream)
        {
            using var br = new BinaryReader(stream, Encoding.Default, true);
            return TryReadCompiledPackage(br);
        }

        public CompiledPackage TryReadCompiledPackage(BinaryReader br)
        {
            var compiledbuffer = new CompiledPackage(_hashService);
            return compiledbuffer.Read(br) switch
            {
                Common.EFileReadErrorCodes.NoError => compiledbuffer,
                _ => null,
            };
        }

        #endregion Methods

        public IWolvenkitFile TryReadCr2WFile(Stream stream) => TryReadRED4File(stream);

        public IWolvenkitFile TryReadCr2WFile(BinaryReader br) => TryReadRED4File(br);

        public IWolvenkitFile TryReadCr2WFileHeaders(Stream stream) => TryReadRED4FileHeaders(stream);

        public IWolvenkitFile TryReadCr2WFileHeaders(BinaryReader br) => TryReadRED4FileHeaders(br);

    }
}
