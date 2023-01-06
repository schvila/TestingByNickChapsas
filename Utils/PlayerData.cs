using System;
using System.Runtime.Serialization;

namespace Utils;

[Serializable]
[DataContract]
public class PlayerData
{
	[DataMember]
	public int? ID { get; set; }

	[DataMember]
	public int IDPlayer { get; set; }

	[DataMember]
	public string Login { get; set; }

	[DataMember]
	public string Password { get; set; }

	[DataMember]
	public string FirstName { get; set; }

	[DataMember]
	public string Surname { get; set; }

	[DataMember]
	public string NickName { get; set; }

	[DataMember]
	public string NickNameTmp { get; set; }

	[DataMember]
	public DateTime? BirthDate { get; set; }

	[DataMember]
	public string BirthCity { get; set; }

	[DataMember]
	public string Mail { get; set; }

	[DataMember]
	public string MailTmp { get; set; }

	[DataMember]
	public string Phone { get; set; }

	[DataMember]
	public string PhoneTmp { get; set; }

	[DataMember]
	public DateTime? AccountFrom { get; set; }

	[DataMember]
	public DateTime? AccountTo { get; set; }

	[DataMember]
	public DateTime? ValidFrom { get; set; }

	[DataMember]
	public string DocumentID { get; set; }

	[DataMember]
	public Player.eValidState DocumentIDIsValid { get; set; }

	[DataMember]
	public string PersonalID { get; set; }

	[DataMember]
	public string Street { get; set; }

	[DataMember]
	public string Number { get; set; }

	[DataMember]
	public string City { get; set; }

	[DataMember]
	public string ZIP { get; set; }

	[DataMember]
	public string Country { get; set; }

	[DataMember]
	public string Nationality { get; set; }

	[DataMember]
	public string BankAccount { get; set; }

	[DataMember]
	public Player.eValidState BankAccountIsValid { get; set; }

	[DataMember]
	public string Card { get; set; }

	[DataMember]
	public Player.eValidState CardIsValid { get; set; }

	[DataMember]
	public DateTime? ValidTo { get; set; }

	[DataMember]
	public string CSC { get; set; }

	[DataMember]
	public bool Newsletter { get; set; }

	[DataMember]
	public short RegistrationStep { get; set; }

	[DataMember]
	public int Language { get; set; }

	[DataMember]
	public int NotifySMS { get; set; }

	[DataMember]
	public int NotifyEmail { get; set; }

	[DataMember]
	public byte Sound { get; set; }

	[DataMember]
	public string Note { get; set; }

	[DataMember]
	public decimal LastStakesSum { get; set; }

	[DataMember]
	public decimal LastStakesBonusSum { get; set; }

	[DataMember]
	public decimal LastWinsSum { get; set; }

	[DataMember]
	public decimal LastWinsBonusSum { get; set; }

	[DataMember]
	public int LastRoundWin { get; set; }

	[DataMember]
	public int LastRoundLost { get; set; }
}
