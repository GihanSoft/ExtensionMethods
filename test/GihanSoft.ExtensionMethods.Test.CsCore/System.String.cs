using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Xunit;

namespace GihanSoft.ExtensionMethods.Test.CsCore
{
    public class System
    {
        [Fact]
        public void DecodeBase64Test()
        {
            var text = "سلام";
            var base64 = text.Decode().EncodeBase64();
            Assert.Equal(Convert.ToBase64String(text.Decode()), base64);
        }

        [Fact]
        public void Base64Test()
        {
            var bytes = new byte[1000];
            RandomNumberGenerator.Fill(bytes);
            var result = bytes.EncodeBase64().DecodeBase64();
            Assert.Equal(bytes, result);
        }
    }
}
