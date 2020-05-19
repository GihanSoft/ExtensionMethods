using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace GihanSoft.ExtensionMethods.Test.CsCore {
    public class System {

        [Fact]
        public void DecodeDefault () {
            var str = "یک رشته‌ی تصادفی";
            var decoded = str.Decode (Encoding.Default);
            Assert.Equal (Encoding.UTF8.GetBytes (str), decoded);
        }

        [Fact]
        public void Decode () {
            var str = "یک رشته‌ی تصادفی";
            var decoded = str.Decode ();
            Assert.Equal (Encoding.UTF8.GetBytes (str), decoded);
        }

        [Fact]
        public void DecodeUTF7 () {
            var str = "یک رشته‌ی تصادفی";
            var decoded1 = str.Decode<UTF7Encoding> ();
            var decoded2 = str.Decode (Encoding.UTF7);
            Assert.Equal (Encoding.UTF7.GetBytes (str), decoded1);
            Assert.Equal (Encoding.UTF7.GetBytes (str), decoded2);
        }

        [Fact]
        public void DecodeUTF8 () {
            var str = "یک رشته‌ی تصادفی";
            var decoded1 = str.Decode<UTF8Encoding> ();
            var decoded2 = str.Decode (Encoding.UTF8);
            Assert.Equal (Encoding.UTF8.GetBytes (str), decoded1);
            Assert.Equal (Encoding.UTF8.GetBytes (str), decoded2);
        }

        [Fact]
        public void DecodeUnicode () {
            var str = "یک رشته‌ی تصادفی";
            var decoded1 = str.Decode<UnicodeEncoding> ();
            var decoded2 = str.Decode (Encoding.Unicode);
            Assert.Equal (Encoding.Unicode.GetBytes (str), decoded1);
            Assert.Equal (Encoding.Unicode.GetBytes (str), decoded2);
        }

        [Fact]
        public void DecodeBigEndian () {
            var str = "یک رشته‌ی تصادفی";
            var decoded = str.Decode (Encoding.BigEndianUnicode);
            Assert.Equal (Encoding.BigEndianUnicode.GetBytes (str), decoded);
        }

        [Fact]
        public void DecodeUTF32 () {
            var str = "یک رشته‌ی تصادفی";
            var decoded1 = str.Decode<UTF32Encoding> ();
            var decoded2 = str.Decode (Encoding.UTF32);
            Assert.Equal (Encoding.UTF32.GetBytes (str), decoded1);
            Assert.Equal (Encoding.UTF32.GetBytes (str), decoded2);
        }

        [Fact]
        public void DecodeASCII () {
            var str = "یک رشته‌ی تصادفی";
            var decoded1 = str.Decode<ASCIIEncoding> ();
            var decoded2 = str.Decode (Encoding.ASCII);
            Assert.Equal (Encoding.ASCII.GetBytes (str), decoded1);
            Assert.Equal (Encoding.ASCII.GetBytes (str), decoded2);
        }

        [Fact]
        public void DecodeAll () {
            var str = "یک رشته‌ی تصادفی";
            var encodings = Encoding.GetEncodings ();
            foreach (var encoding in encodings) {
                var decoded = str.Decode (encoding.GetEncoding ());
                Assert.Equal (encoding.GetEncoding ().GetBytes (str), decoded);
            }
        }
    }
}