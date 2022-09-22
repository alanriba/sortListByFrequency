using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Encora.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Xunit;

namespace EncoraTest
{
    [TestClass]
    public class GetStringSort
    {

        [TestMethod]
        public async Task GetSortOk()
        {
            //Arrange
            StringBusiness business = new StringBusiness();

            //Act
            String str = await business.GetStringSortedFrequency("abaccadcc");

            // Assert
            Xunit.Assert.NotNull(str);
            Xunit.Assert.NotEmpty(str);
            Xunit.Assert.Equal("ccccaaabd", await business.GetStringSortedFrequency("abaccadcc"));
            Xunit.Assert.Equal("xxyyz", await business.GetStringSortedFrequency("xyzxy"));

            Xunit.Assert.Equal("gggdlquvwz", await business.GetStringSortedFrequency("dulgvgzwqg"));
            Xunit.Assert.Equal("tttgjmrwxy", await business.GetStringSortedFrequency("gxtjtmtywr"));
            Xunit.Assert.Equal("nnghilptux", await business.GetStringSortedFrequency("hnlnxiupgt"));
            Xunit.Assert.Equal("cgijkoptvz", await business.GetStringSortedFrequency("gzjotckivp"));
            Xunit.Assert.Equal("ddppwwaest", await business.GetStringSortedFrequency("dpwwsdptae"));
            Xunit.Assert.Equal("ccppbiklns", await business.GetStringSortedFrequency("pcscpilknb"));
            Xunit.Assert.Equal("ffhhblmtvy", await business.GetStringSortedFrequency("btvyhhmflf"));
            Xunit.Assert.Equal("rrrttacnqx", await business.GetStringSortedFrequency("artrtnqxcr"));
            Xunit.Assert.Equal("ccnnadmort", await business.GetStringSortedFrequency("nrtcmcoadn"));
            Xunit.Assert.Equal("ffkkdegnst", await business.GetStringSortedFrequency("fkdsgnekft"));


            Xunit.Assert.Equal("eeuuwwabnz", await business.GetStringSortedFrequency("wzenwebuau"));
            Xunit.Assert.Equal("fklnovwxyz", await business.GetStringSortedFrequency("vokfxzynwl"));
            Xunit.Assert.Equal("eedfklnrxy", await business.GetStringSortedFrequency("neldfeyrxk"));
            Xunit.Assert.Equal("ddafgioqsw", await business.GetStringSortedFrequency("wqadfiodgs"));
            Xunit.Assert.Equal("ccbfikuvyz", await business.GetStringSortedFrequency("ykiuvzfcbc"));

            Xunit.Assert.Equal("ackmq", await business.GetStringSortedFrequency("qakmc"));
            Xunit.Assert.Equal("rrbkt", await business.GetStringSortedFrequency("rrtbk"));
            Xunit.Assert.Equal("ainvx", await business.GetStringSortedFrequency("vaixn"));
            Xunit.Assert.Equal("jmnpw", await business.GetStringSortedFrequency("wmpnj"));
            Xunit.Assert.Equal("iopru", await business.GetStringSortedFrequency("uproi"));
            Xunit.Assert.Equal("abkst", await business.GetStringSortedFrequency("btska"));
            Xunit.Assert.Equal("ejqrw", await business.GetStringSortedFrequency("ejqwr"));
            Xunit.Assert.Equal("llegw", await business.GetStringSortedFrequency("elwlg"));
            Xunit.Assert.Equal("ooaiy", await business.GetStringSortedFrequency("oaoiy"));
            Xunit.Assert.Equal("hknqr", await business.GetStringSortedFrequency("hrqkn"));

            Xunit.Assert.Equal("ijmpz", await business.GetStringSortedFrequency("pzjim"));
            Xunit.Assert.Equal("nnfjq", await business.GetStringSortedFrequency("njnfq"));
            Xunit.Assert.Equal("hosxy", await business.GetStringSortedFrequency("xyohs"));

            Xunit.Assert.Equal("cqsxy", await business.GetStringSortedFrequency("xqycs"));
            Xunit.Assert.Equal("abeox", await business.GetStringSortedFrequency("beoax"));
            Xunit.Assert.Equal("afkos", await business.GetStringSortedFrequency("afkso"));
            Xunit.Assert.Equal("bdilt", await business.GetStringSortedFrequency("bldit"));
            Xunit.Assert.Equal("grswy", await business.GetStringSortedFrequency("gwrys"));
        }
    }
}