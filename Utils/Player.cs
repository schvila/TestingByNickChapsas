using System;
using System.Runtime.Serialization;

namespace Utils;

[DataContract]
public class Player
{
	[DataContract]
	public enum ePlayerResult
	{
		Ok,
		UnknownPlayer,
		UnknownBonus,
		BonusAlreadyApplied
	}

	[DataContract]
	public enum eAccountType
	{
		[EnumMember]
		Temp = 0,
		[EnumMember]
		Full = 1,
		[EnumMember]
		Free = 2,
		[EnumMember]
		Test = 10,
		[EnumMember]
		Anonymous = 20,
		[EnumMember]
		TempCanceled = 50,
		[EnumMember]
		FullCanceled = 51,
		[EnumMember]
		NotSet = -1
	}

	[DataContract]
	public enum eValidState
	{
		[EnumMember]
		NotValid,
		[EnumMember]
		Valid,
		[EnumMember]
		ValidationInProgress
	}

	[Flags]
	public enum eNotifyType
	{
		Tournament_start = 1,
		Tournament_new = 2,
		Advert = 4
	}

	public static readonly int DAYS_TO_CANCEL_TEMP_ACCOUNT = 30;

	[DataMember]
	public int? ID { get; set; }

	[DataMember]
	public string PlayerID { get; set; }

	[DataMember]
	public eAccountType AccountType { get; set; }

	[DataMember]
	public decimal? Amount { get; set; }

	[DataMember]
	public bool Accounted { get; set; }

	[DataMember]
	public bool CanPlay { get; set; }

	[DataMember]
	public DateTime? LoginTime { get; set; }

	[DataMember]
	public decimal? LoginTimeDay { get; set; }

	[DataMember]
	public short? LoginCountMonth { get; set; }

	[DataMember]
	public DateTime? LogoutTime { get; set; }

	[DataMember]
	public DateTime? LastActionTime { get; set; }

	[DataMember]
	public DateTime? PlayTimeStart { get; set; }

	[DataMember]
	public decimal? StakesSum { get; set; }

	[DataMember]
	public decimal? StakesSumDay { get; set; }

	[DataMember]
	public decimal? StakesSumMonth { get; set; }

	[DataMember]
	public decimal? WinsSum { get; set; }

	[DataMember]
	public decimal? WinsSumDay { get; set; }

	[DataMember]
	public decimal? WinsSumMonth { get; set; }

	[DataMember]
	public decimal? In { get; set; }

	[DataMember]
	public decimal? Out { get; set; }

	[DataMember]
	public decimal? InDay { get; set; }

	[DataMember]
	public decimal? OutDay { get; set; }

	[DataMember]
	public decimal? InMonth { get; set; }

	[DataMember]
	public decimal? OutMonth { get; set; }

	[DataMember]
	public decimal? InTotal { get; set; }

	[DataMember]
	public decimal? OutTotal { get; set; }

	[DataMember]
	public decimal? MaxCredit { get; set; }

	[DataMember]
	public decimal? MaxStake { get; set; }

	[DataMember]
	public decimal? MaxWin { get; set; }

	[DataMember]
	public decimal? MaxLostHour { get; set; }

	[DataMember]
	public DateTime? MaxLostHourTime { get; set; }

	[DataMember]
	public DateTime? LastIFUpdateTime { get; set; }

	[DataMember]
	public decimal? StakesBonusSum { get; set; }

	[DataMember]
	public decimal? WinsBonusSum { get; set; }

	[DataMember]
	public int? RoundWin { get; set; }

	[DataMember]
	public int? RoundLost { get; set; }

	[DataMember]
	public PlayerData PlayerData { get; set; }

	[DataMember]
	public PlayerLimits PlayerLimits { get; set; }

	public void ClearForSaveIcrement()
	{
		Amount = default(decimal);
		StakesSum = default(decimal);
		WinsSum = default(decimal);
		In = default(decimal);
		Out = default(decimal);
		InMonth = default(decimal);
		OutMonth = default(decimal);
		InTotal = default(decimal);
		OutTotal = default(decimal);
	}
}
