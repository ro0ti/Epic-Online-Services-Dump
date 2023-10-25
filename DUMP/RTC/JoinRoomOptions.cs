using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	public struct JoinRoomOptions
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000461")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001105")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001106")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000462")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001107")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001108")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000463")]
		public Utf8String ClientBaseUrl
		{
			[Token(Token = "0x6001109")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600110A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000464")]
		public Utf8String ParticipantToken
		{
			[Token(Token = "0x600110B")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600110C")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000465")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x600110D")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600110E")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000054A4 File Offset: 0x000036A4
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000466")]
		public JoinRoomFlags Flags
		{
			[Token(Token = "0x600110F")]
			[Address(RVA = "0x3D2E70", Offset = "0x3D1470", VA = "0x1803D2E70")]
			[CompilerGenerated]
			readonly get
			{
				return JoinRoomFlags.None;
			}
			[Token(Token = "0x6001110")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000054BC File Offset: 0x000036BC
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000467")]
		public bool ManualAudioInputEnabled
		{
			[Token(Token = "0x6001111")]
			[Address(RVA = "0x4F5200", Offset = "0x4F3800", VA = "0x1804F5200")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001112")]
			[Address(RVA = "0x4F5220", Offset = "0x4F3820", VA = "0x1804F5220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x000054D4 File Offset: 0x000036D4
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000468")]
		public bool ManualAudioOutputEnabled
		{
			[Token(Token = "0x6001113")]
			[Address(RVA = "0x4F5210", Offset = "0x4F3810", VA = "0x1804F5210")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001114")]
			[Address(RVA = "0x4F5230", Offset = "0x4F3830", VA = "0x1804F5230")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
