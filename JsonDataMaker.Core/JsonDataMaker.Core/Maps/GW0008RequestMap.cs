using BankVision.WebAPI.Models.GW0008.Request;
using CsvHelper.Configuration;

namespace JsonDataMaker.Core.Maps
{
    /// <summary>
    /// 預金口座残高照会RequestMap
    /// </summary>
    public class GW0008RequestMap : ClassMap<RequestMessageData>
    {
        public GW0008RequestMap()
        {
            // 店番
            Map(x => x.YokinkozaZandakashokai.ShokaiKomoku.temban)
                .Index(0).Name("temban");
            // 科目コード
            Map(x => x.YokinkozaZandakashokai.ShokaiKomoku.kamokuCode)
                .Index(1).Name("kamokuCode");
            // 口座番号
            Map(x => x.YokinkozaZandakashokai.ShokaiKomoku.kozabango)
                .Index(2).Name("kozabango");
            // 過振区分
            Map(x => x.YokinkozaZandakashokai.ShokaiKomoku.kaburiKubun)
                .Index(3).Name("kaburiKubun");
            // 契約者ID
            Map(x => x.YokinkozaZandakashokai.KensaKomoku.keiyakushaId)
                .Index(4).Name("keiyakushaId");
        }
    }
}
