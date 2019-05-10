﻿using JsonDataMaker.Core.DomainObjects;
using JsonDataMaker.Core.Parsers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace JsonDataMaker.Core.Tests.Parsers
{
    public class GW0008RequestCsvParserTests
    {
        [Fact]
        public void Parse()
        {
            var target = new GW0008RequestCsvParser();

            var csv = new StringBuilder();
            foreach (string line in GetCsvStrings())
            {
                csv.AppendLine(line);
            }

            var stream = new MemoryStream(Encoding.UTF8.GetBytes(csv.ToString()));
            var actual = target.Parse(stream);

            var expected = new List<GW0008RequestObject>()
            {
                new GW0008RequestObject()
                {
                    FileId = 1001,
                    temban = 1002,
                    kamokuCode = 1003,
                    kozabango = 1004,
                    kaburiKubun = 1005,
                    keiyakushaId = 1006,
                },
                new GW0008RequestObject()
                {
                    FileId = 1011,
                    temban = 1012,
                    kamokuCode = 1013,
                    kozabango = 1014,
                    kaburiKubun = 1015,
                    keiyakushaId = 1016,
                },
                new GW0008RequestObject()
                {
                    FileId = 1021,
                    temban = 1022,
                    kamokuCode = 1023,
                    kozabango = 1024,
                    kaburiKubun = 1025,
                    keiyakushaId = 1026,
                },
            };

            actual.Is(expected, new JsonComparer());
        }

        private IEnumerable<string> GetCsvStrings()
        {
            // ヘッダ部
            yield return "FileId,temban,kamokuCode,kozabango,kaburiKubun,keiyakushaId";
            // データ部
            yield return "1001,1002,1003,1004,1005,1006";
            yield return "1011,1012,1013,1014,1015,1016";
            yield return "1021,1022,1023,1024,1025,1026";
        }
    }
}
