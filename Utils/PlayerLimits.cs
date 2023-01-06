using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Utils
{
    [Serializable]
    [DataContract]
    public class PlayerLimits
    {
		/// <summary>ID objektu</summary>
		[DataMember]
		public int? ID { get; set; }
		
        /// <summary>ID hráèe</summary>
		[DataMember]
		public int IDPlayer { get; set; }

        /// <summary>maximální výše sázek za 1 den</summary>
        [DataMember]
        public decimal? LimitStakesDay { get; set; }

        /// <summary>maximální výše sázek za 1 kalendáøní mìsíc</summary>
        [DataMember]
        public decimal? LimitStakesMonth { get; set; }

        /// <summary>maximální èistá prohra za 1 den
        /// aktuální stav zjistím jako InDay-OutDay-aktuální kredit</summary>
        [DataMember]
        public decimal? LimitLostDay { get; set; }

        /// <summary>maximální èistá prohra za 1 kalendáøní mìsíc</summary>
        [DataMember]
        public decimal? LimitLostMonth { get; set; }

        /// <summary>poèet pøihlášení do uživatelského konta za 1 kalendáøní mìsíc</summary>
        [DataMember]
        public decimal? LimitLoginCountMonth { get; set; }


        /// <summary>2017_20_10 zmena z [h] na [s] denního pøihlášení na uživatelském kontu do jeho automatického odhlášení</summary>
        [DataMember]
        public decimal? LimitLoginTimeDay { get; set; }

        /// <summary>2017_20_10 zmena z [h] na [s] doba, po kterou se nebude moci zúèastnit hry po jeho odhlášení z uživatelského konta [s]</summary>
        [DataMember]
        public decimal? LimitTimeToNextLogin { get; set; }

        //Default konstruktor kvùli JSON deserializaci
        public PlayerLimits()     {}

    }


    [DataContract]
    public class PlayerLimitsEx
    {
        /// <summary></summary>
        [DataMember]
        public int? ID { get; set; }
        /// <summary></summary>
        [DataMember]
        public int IDPlayer { get; set; }


        /// <summary>maximální denní výše sázek</summary>
        [DataMember]
        public Limit LimitStakesDay = new Limit();
        /// <summary>maximální výše sázek za 1 mìsíc</summary>
        [DataMember]
        public Limit LimitStakesMonth = new Limit();
        /// <summary>výše èisté prohry za 1 den</summary>
        [DataMember]
        public Limit LimitLostDay = new Limit();
        /// <summary>výše èisté prohry za 1 mìsíc</summary>
        [DataMember]
        public Limit LimitLostMonth = new Limit();
        /// <summary>max. poèet pøihlášení do uživ. konta za mìsíc</summary>
        [DataMember]
        public Limit LimitLoginCountMonth = new Limit();
        /// <summary>max. doba denního pøihlášení do autom. odhlášení</summary>
        [DataMember]
        public Limit LimitLoginTimeDay = new Limit();
        /// <summary>doba, po kterou hráè nesmí hrát po odhlášení z konta</summary>
        [DataMember]
        public Limit LimitTimeToNextLogin = new Limit();


        //Default konstruktor kvùli JSON deserializaci
        public PlayerLimitsEx() { }

    }
    
    [DataContract]
    public class Limit
    {
        [DataMember]
        /// <summary>Aktuální platný stav</summary>
        public decimal? Current;
        [DataMember]
        /// <summary>Nový zatím neplatný stav</summary>
        public decimal? New;
        [DataMember]
        /// <summary>Datum platnosti nového stavu</summary>
        public DateTime? ValidDate;

        //Default konstruktor kvùli JSON deserializaci
        public Limit() { }

    }

}
