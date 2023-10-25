using System;
using Epic.OnlineServices.Achievements;
using Epic.OnlineServices.AntiCheatClient;
using Epic.OnlineServices.AntiCheatServer;
using Epic.OnlineServices.Auth;
using Epic.OnlineServices.Connect;
using Epic.OnlineServices.CustomInvites;
using Epic.OnlineServices.Ecom;
using Epic.OnlineServices.Friends;
using Epic.OnlineServices.IntegratedPlatform;
using Epic.OnlineServices.KWS;
using Epic.OnlineServices.Leaderboards;
using Epic.OnlineServices.Lobby;
using Epic.OnlineServices.Metrics;
using Epic.OnlineServices.Mods;
using Epic.OnlineServices.P2P;
using Epic.OnlineServices.PlayerDataStorage;
using Epic.OnlineServices.Presence;
using Epic.OnlineServices.ProgressionSnapshot;
using Epic.OnlineServices.Reports;
using Epic.OnlineServices.RTC;
using Epic.OnlineServices.RTCAdmin;
using Epic.OnlineServices.Sanctions;
using Epic.OnlineServices.Sessions;
using Epic.OnlineServices.Stats;
using Epic.OnlineServices.TitleStorage;
using Epic.OnlineServices.UI;
using Epic.OnlineServices.UserInfo;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000721 RID: 1825
	[Token(Token = "0x2000721")]
	public sealed class PlatformInterface : Handle
	{
		// Token: 0x06002E84 RID: 11908 RVA: 0x0000C08C File Offset: 0x0000A28C
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x57BFE0", Offset = "0x57A5E0", VA = "0x18057BFE0")]
		public static Result Initialize(ref AndroidInitializeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E85")]
		[Address(RVA = "0x427FC0", Offset = "0x4265C0", VA = "0x180427FC0")]
		public PlatformInterface()
		{
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x4B8FB0", Offset = "0x4B75B0", VA = "0x1804B8FB0")]
		public PlatformInterface(IntPtr innerHandle)
		{
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x57AC00", Offset = "0x579200", VA = "0x18057AC00")]
		public Result CheckForLauncherAndRestart()
		{
			return Result.Success;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x57AD10", Offset = "0x579310", VA = "0x18057AD10")]
		public static PlatformInterface Create(ref Options options)
		{
			return null;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E89")]
		[Address(RVA = "0x57AE10", Offset = "0x579410", VA = "0x18057AE10")]
		public AchievementsInterface GetAchievementsInterface()
		{
			return null;
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x0000C0BC File Offset: 0x0000A2BC
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x57AE90", Offset = "0x579490", VA = "0x18057AE90")]
		public Result GetActiveCountryCode(EpicAccountId localUserId, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x57AF50", Offset = "0x579550", VA = "0x18057AF50")]
		public Result GetActiveLocaleCode(EpicAccountId localUserId, out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0x57B010", Offset = "0x579610", VA = "0x18057B010")]
		public AntiCheatClientInterface GetAntiCheatClientInterface()
		{
			return null;
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E8D")]
		[Address(RVA = "0x57B090", Offset = "0x579690", VA = "0x18057B090")]
		public AntiCheatServerInterface GetAntiCheatServerInterface()
		{
			return null;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0x57B110", Offset = "0x579710", VA = "0x18057B110")]
		public ApplicationStatus GetApplicationStatus()
		{
			return ApplicationStatus.BackgroundConstrained;
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x57B120", Offset = "0x579720", VA = "0x18057B120")]
		public AuthInterface GetAuthInterface()
		{
			return null;
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x57B1A0", Offset = "0x5797A0", VA = "0x18057B1A0")]
		public ConnectInterface GetConnectInterface()
		{
			return null;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x57B220", Offset = "0x579820", VA = "0x18057B220")]
		public CustomInvitesInterface GetCustomInvitesInterface()
		{
			return null;
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x0000C104 File Offset: 0x0000A304
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x57B2A0", Offset = "0x5798A0", VA = "0x18057B2A0")]
		public Result GetDesktopCrossplayStatus(ref GetDesktopCrossplayStatusOptions options, out DesktopCrossplayStatusInfo outDesktopCrossplayStatusInfo)
		{
			return Result.Success;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x57B370", Offset = "0x579970", VA = "0x18057B370")]
		public EcomInterface GetEcomInterface()
		{
			return null;
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x57B3F0", Offset = "0x5799F0", VA = "0x18057B3F0")]
		public FriendsInterface GetFriendsInterface()
		{
			return null;
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x57B470", Offset = "0x579A70", VA = "0x18057B470")]
		public IntegratedPlatformInterface GetIntegratedPlatformInterface()
		{
			return null;
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x57B4F0", Offset = "0x579AF0", VA = "0x18057B4F0")]
		public KWSInterface GetKWSInterface()
		{
			return null;
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x57B570", Offset = "0x579B70", VA = "0x18057B570")]
		public LeaderboardsInterface GetLeaderboardsInterface()
		{
			return null;
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E98")]
		[Address(RVA = "0x57B5F0", Offset = "0x579BF0", VA = "0x18057B5F0")]
		public LobbyInterface GetLobbyInterface()
		{
			return null;
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x57B670", Offset = "0x579C70", VA = "0x18057B670")]
		public MetricsInterface GetMetricsInterface()
		{
			return null;
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x57B6F0", Offset = "0x579CF0", VA = "0x18057B6F0")]
		public ModsInterface GetModsInterface()
		{
			return null;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x0000C11C File Offset: 0x0000A31C
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x57B770", Offset = "0x579D70", VA = "0x18057B770")]
		public NetworkStatus GetNetworkStatus()
		{
			return NetworkStatus.Disabled;
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x0000C134 File Offset: 0x0000A334
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x57B780", Offset = "0x579D80", VA = "0x18057B780")]
		public Result GetOverrideCountryCode(out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x0000C14C File Offset: 0x0000A34C
		[Token(Token = "0x6002E9D")]
		[Address(RVA = "0x57B820", Offset = "0x579E20", VA = "0x18057B820")]
		public Result GetOverrideLocaleCode(out Utf8String outBuffer)
		{
			return Result.Success;
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E9E")]
		[Address(RVA = "0x57B8C0", Offset = "0x579EC0", VA = "0x18057B8C0")]
		public P2PInterface GetP2PInterface()
		{
			return null;
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002E9F")]
		[Address(RVA = "0x57B940", Offset = "0x579F40", VA = "0x18057B940")]
		public PlayerDataStorageInterface GetPlayerDataStorageInterface()
		{
			return null;
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA0")]
		[Address(RVA = "0x57B9C0", Offset = "0x579FC0", VA = "0x18057B9C0")]
		public PresenceInterface GetPresenceInterface()
		{
			return null;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA1")]
		[Address(RVA = "0x57BA40", Offset = "0x57A040", VA = "0x18057BA40")]
		public ProgressionSnapshotInterface GetProgressionSnapshotInterface()
		{
			return null;
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x57BAC0", Offset = "0x57A0C0", VA = "0x18057BAC0")]
		public RTCAdminInterface GetRTCAdminInterface()
		{
			return null;
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x57BB40", Offset = "0x57A140", VA = "0x18057BB40")]
		public RTCInterface GetRTCInterface()
		{
			return null;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA4")]
		[Address(RVA = "0x57BBC0", Offset = "0x57A1C0", VA = "0x18057BBC0")]
		public ReportsInterface GetReportsInterface()
		{
			return null;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA5")]
		[Address(RVA = "0x57BC40", Offset = "0x57A240", VA = "0x18057BC40")]
		public SanctionsInterface GetSanctionsInterface()
		{
			return null;
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA6")]
		[Address(RVA = "0x57BCC0", Offset = "0x57A2C0", VA = "0x18057BCC0")]
		public SessionsInterface GetSessionsInterface()
		{
			return null;
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA7")]
		[Address(RVA = "0x57BD40", Offset = "0x57A340", VA = "0x18057BD40")]
		public StatsInterface GetStatsInterface()
		{
			return null;
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x57BDC0", Offset = "0x57A3C0", VA = "0x18057BDC0")]
		public TitleStorageInterface GetTitleStorageInterface()
		{
			return null;
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x57BE40", Offset = "0x57A440", VA = "0x18057BE40")]
		public UIInterface GetUIInterface()
		{
			return null;
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x57BEC0", Offset = "0x57A4C0", VA = "0x18057BEC0")]
		public UserInfoInterface GetUserInfoInterface()
		{
			return null;
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x0000C164 File Offset: 0x0000A364
		[Token(Token = "0x6002EAB")]
		[Address(RVA = "0x57BF40", Offset = "0x57A540", VA = "0x18057BF40")]
		public static Result Initialize(ref InitializeOptions options)
		{
			return Result.Success;
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x57C080", Offset = "0x57A680", VA = "0x18057C080")]
		public void Release()
		{
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x0000C17C File Offset: 0x0000A37C
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x57C090", Offset = "0x57A690", VA = "0x18057C090")]
		public Result SetApplicationStatus(ApplicationStatus newStatus)
		{
			return Result.Success;
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x0000C194 File Offset: 0x0000A394
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x57C0A0", Offset = "0x57A6A0", VA = "0x18057C0A0")]
		public Result SetNetworkStatus(NetworkStatus newStatus)
		{
			return Result.Success;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x0000C1AC File Offset: 0x0000A3AC
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x57C0B0", Offset = "0x57A6B0", VA = "0x18057C0B0")]
		public Result SetOverrideCountryCode(Utf8String newCountryCode)
		{
			return Result.Success;
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x0000C1C4 File Offset: 0x0000A3C4
		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0x57C140", Offset = "0x57A740", VA = "0x18057C140")]
		public Result SetOverrideLocaleCode(Utf8String newLocaleCode)
		{
			return Result.Success;
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x0000C1DC File Offset: 0x0000A3DC
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x57C1D0", Offset = "0x57A7D0", VA = "0x18057C1D0")]
		public static Result Shutdown()
		{
			return Result.Success;
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x57C1E0", Offset = "0x57A7E0", VA = "0x18057C1E0")]
		public void Tick()
		{
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EB3")]
		[Address(RVA = "0x57C1F0", Offset = "0x57A7F0", VA = "0x18057C1F0")]
		public static Utf8String ToString(ApplicationStatus applicationStatus)
		{
			return null;
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EB4")]
		[Address(RVA = "0x57C260", Offset = "0x57A860", VA = "0x18057C260")]
		public static Utf8String ToString(NetworkStatus networkStatus)
		{
			return null;
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x57AC10", Offset = "0x579210", VA = "0x18057AC10")]
		public static PlatformInterface Create(ref WindowsOptions options)
		{
			return null;
		}

		// Token: 0x040014BD RID: 5309
		[Token(Token = "0x40014BD")]
		public const int AndroidInitializeoptionssysteminitializeoptionsApiLatest = 2;

		// Token: 0x040014BE RID: 5310
		[Token(Token = "0x40014BE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Utf8String CheckforlauncherandrestartEnvVar;

		// Token: 0x040014BF RID: 5311
		[Token(Token = "0x40014BF")]
		public const int ClientcredentialsClientidMaxLength = 64;

		// Token: 0x040014C0 RID: 5312
		[Token(Token = "0x40014C0")]
		public const int ClientcredentialsClientsecretMaxLength = 64;

		// Token: 0x040014C1 RID: 5313
		[Token(Token = "0x40014C1")]
		public const int CountrycodeMaxBufferLen = 5;

		// Token: 0x040014C2 RID: 5314
		[Token(Token = "0x40014C2")]
		public const int CountrycodeMaxLength = 4;

		// Token: 0x040014C3 RID: 5315
		[Token(Token = "0x40014C3")]
		public const int GetdesktopcrossplaystatusApiLatest = 1;

		// Token: 0x040014C4 RID: 5316
		[Token(Token = "0x40014C4")]
		public const int InitializeApiLatest = 4;

		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		public const int InitializeThreadaffinityApiLatest = 2;

		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		public const int InitializeoptionsProductnameMaxLength = 64;

		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		public const int InitializeoptionsProductversionMaxLength = 64;

		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		public const int LocalecodeMaxBufferLen = 10;

		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		public const int LocalecodeMaxLength = 9;

		// Token: 0x040014CA RID: 5322
		[Token(Token = "0x40014CA")]
		public const int OptionsApiLatest = 13;

		// Token: 0x040014CB RID: 5323
		[Token(Token = "0x40014CB")]
		public const int OptionsDeploymentidMaxLength = 64;

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		public const int OptionsEncryptionkeyLength = 64;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		public const int OptionsProductidMaxLength = 64;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		public const int OptionsSandboxidMaxLength = 64;

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		public const int RtcoptionsApiLatest = 2;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		public const int WindowsRtcoptionsplatformspecificoptionsApiLatest = 1;
	}
}
