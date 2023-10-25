using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAdmin
{
	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	public struct SetParticipantHardMuteOptions
	{
		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000422")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001071")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001072")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001074 RID: 4212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000423")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001073")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001074")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00005324 File Offset: 0x00003524
		// (set) Token: 0x06001076 RID: 4214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000424")]
		public bool Mute
		{
			[Token(Token = "0x6001075")]
			[Address(RVA = "0x3D3060", Offset = "0x3D1660", VA = "0x1803D3060")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001076")]
			[Address(RVA = "0x3D3070", Offset = "0x3D1670", VA = "0x1803D3070")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
