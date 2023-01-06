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
		
        /// <summary>ID hr��e</summary>
		[DataMember]
		public int IDPlayer { get; set; }

        /// <summary>maxim�ln� v��e s�zek za 1 den</summary>
        [DataMember]
        public decimal? LimitStakesDay { get; set; }

        /// <summary>maxim�ln� v��e s�zek za 1 kalend��n� m�s�c</summary>
        [DataMember]
        public decimal? LimitStakesMonth { get; set; }

        /// <summary>maxim�ln� �ist� prohra za 1 den
        /// aktu�ln� stav zjist�m jako InDay-OutDay-aktu�ln� kredit</summary>
        [DataMember]
        public decimal? LimitLostDay { get; set; }

        /// <summary>maxim�ln� �ist� prohra za 1 kalend��n� m�s�c</summary>
        [DataMember]
        public decimal? LimitLostMonth { get; set; }

        /// <summary>po�et p�ihl�en� do u�ivatelsk�ho konta za 1 kalend��n� m�s�c</summary>
        [DataMember]
        public decimal? LimitLoginCountMonth { get; set; }


        /// <summary>2017_20_10 zmena z [h] na [s] denn�ho p�ihl�en� na u�ivatelsk�m kontu do jeho automatick�ho odhl�en�</summary>
        [DataMember]
        public decimal? LimitLoginTimeDay { get; set; }

        /// <summary>2017_20_10 zmena z [h] na [s] doba, po kterou se nebude moci z��astnit hry po jeho odhl�en� z u�ivatelsk�ho konta [s]</summary>
        [DataMember]
        public decimal? LimitTimeToNextLogin { get; set; }

        //Default konstruktor kv�li JSON deserializaci
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


        /// <summary>maxim�ln� denn� v��e s�zek</summary>
        [DataMember]
        public Limit LimitStakesDay = new Limit();
        /// <summary>maxim�ln� v��e s�zek za 1 m�s�c</summary>
        [DataMember]
        public Limit LimitStakesMonth = new Limit();
        /// <summary>v��e �ist� prohry za 1 den</summary>
        [DataMember]
        public Limit LimitLostDay = new Limit();
        /// <summary>v��e �ist� prohry za 1 m�s�c</summary>
        [DataMember]
        public Limit LimitLostMonth = new Limit();
        /// <summary>max. po�et p�ihl�en� do u�iv. konta za m�s�c</summary>
        [DataMember]
        public Limit LimitLoginCountMonth = new Limit();
        /// <summary>max. doba denn�ho p�ihl�en� do autom. odhl�en�</summary>
        [DataMember]
        public Limit LimitLoginTimeDay = new Limit();
        /// <summary>doba, po kterou hr�� nesm� hr�t po odhl�en� z konta</summary>
        [DataMember]
        public Limit LimitTimeToNextLogin = new Limit();


        //Default konstruktor kv�li JSON deserializaci
        public PlayerLimitsEx() { }

    }
    
    [DataContract]
    public class Limit
    {
        [DataMember]
        /// <summary>Aktu�ln� platn� stav</summary>
        public decimal? Current;
        [DataMember]
        /// <summary>Nov� zat�m neplatn� stav</summary>
        public decimal? New;
        [DataMember]
        /// <summary>Datum platnosti nov�ho stavu</summary>
        public DateTime? ValidDate;

        //Default konstruktor kv�li JSON deserializaci
        public Limit() { }

    }

}
