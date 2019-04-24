using System;

namespace JsonDataMaker.Controller
{
    public class LogicFactory
    {
        private const string request = "request";
        private const string response = "response";
        public IGWLogic CreateLogic(string gWnumber, string reqOrRes, ReadCsv csv, JsonFileWriter jf)
        {
            switch (gWnumber)
            {
                case "GW0008":
                    {
                        if (reqOrRes == request)
                            return new GW0008RequestLogic(csv, jf);
                        return new GW0008ResponseLogic(csv, jf);
                    }
                case "GW1002":
                    {
                        if (reqOrRes == request)
                            return new GW1002RequestLogic(csv, jf);
                        return new GW1002ResponseLogic(csv, jf);
                }
                default:
                    throw new ArgumentException("\n対象のファクトリがありませんでした");
            }
        }
    }
}