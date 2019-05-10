using CsvHelper.Configuration;
using JsonDataMaker.Core.DomainObjects;

namespace JsonDataMaker.Core.Maps
{
    public class GW0008RequestMap : ClassMap<GW0008RequestObject>
    {
        public GW0008RequestMap()
        {
            Map(x => x.FileId).Index(0).Name("FileId");
            Map(x => x.temban).Index(1).Name("temban");
            Map(x => x.kamokuCode).Index(2).Name("kamokuCode");
            Map(x => x.kozabango).Index(3).Name("kozabango");
            Map(x => x.kaburiKubun).Index(4).Name("kaburiKubun");
            Map(x => x.keiyakushaId).Index(5).Name("keiyakushaId");
        }
    }
}
