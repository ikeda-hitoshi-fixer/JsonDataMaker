using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;
using JsonDataMaker.CsvMapper;
using Newtonsoft.Json;
using BankVision.WebAPI.Models.Common;
using JsonDataMaker.Models.GW1002.Request;
using JsonDataMaker.Models.GW1002.Response;

namespace JsonDataMaker.Controller
{
    public class GW1002RequestLogic : IGWLogic
    {
        private readonly ReadCsv _readCsv;
        private readonly JsonFileWriter _jsonFileWriter;
        private const string apiNo = "GW1002";
        private const string request = "request";
        private const string response = "response";

        public GW1002RequestLogic(ReadCsv readCsv, JsonFileWriter jsonFileWriter)
        {
            _readCsv = readCsv;
            _jsonFileWriter = jsonFileWriter;
        }

        public void CreateData(string outputpath, CsvReader csv)
        {
            int i = 0;
            var data = _readCsv.Fetcher<GW1002RequestJson, GW1002RequestMapper>(csv);
            foreach (GW1002RequestJson item in data)
            {
                item.RequestMessageData.WisRequestSystemInfo = new WisRequestSystemInfo()
                {
                    version = "",
                    clientId = "CB02",
                    clientTraceId = "6b4f47a4-3e5d-4157-a8a8-a7400b877af9",
                    transactionId = "",
                    requestType = 0,
                    clientKey = "E1234CC5-6789-0AB1-2345-67890AC1F23"
                };
                _jsonFileWriter.New(item.RequestMessageData, item.FileNo, apiNo, request, outputpath);
                i++;
            }
            Console.WriteLine($"\n {i}件のファイルを出力しました");
        }

        public void CreateListData(string outputpath, CsvReader csv1, CsvReader csv2)
        {
            throw new NotImplementedException();
        }
    }
}