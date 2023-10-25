using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	public struct ParticipantStatusChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600118B RID: 4491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000486")]
		public object ClientData
		{
			[Token(Token = "0x600118A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600118B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600118D RID: 4493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000487")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600118C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000488")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600118E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600118F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000489")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6001190")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x0000554C File Offset: 0x0000374C
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700048A")]
		public RTCParticipantStatus ParticipantStatus
		{
			[Token(Token = "0x6001192")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return RTCParticipantStatus.Joined;
			}
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700048B")]
		public ParticipantMetadata[] ParticipantMetadata
		{
			[Token(Token = "0x6001194")]
			[Address(RVA = "0x444770", Offset = "0x442D70", VA = "0x180444770")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x444800", Offset = "0x442E00", VA = "0x180444800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00005564 File Offset: 0x00003764
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700048C")]
		public bool ParticipantInBlocklist
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x4BBE80", Offset = "0x4BA480", VA = "0x1804BBE80")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x4BBEB0", Offset = "0x4BA4B0", VA = "0x1804BBEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x6001198")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001199")]
		[Address(RVA = "0x4F8BB0", Offset = "0x4F71B0", VA = "0x1804F8BB0")]
		internal void Set(ref ParticipantStatusChangedCallbackInfoInternal other)
		{
		}
	}
}
