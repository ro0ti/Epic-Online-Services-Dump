using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x0200020E RID: 526
	[Token(Token = "0x200020E")]
	public struct ParticipantUpdatedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000367")]
		public object ClientData
		{
			[Token(Token = "0x6000E67")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E68")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000368")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000E69")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E6A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000369")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000E6B")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E6C")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700036A")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x6000E6D")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x00004B14 File Offset: 0x00002D14
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700036B")]
		public bool Speaking
		{
			[Token(Token = "0x6000E6F")]
			[Address(RVA = "0x4BBE70", Offset = "0x4BA470", VA = "0x1804BBE70")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E70")]
			[Address(RVA = "0x4BBEA0", Offset = "0x4BA4A0", VA = "0x1804BBEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00004B2C File Offset: 0x00002D2C
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700036C")]
		public RTCAudioStatus AudioStatus
		{
			[Token(Token = "0x6000E71")]
			[Address(RVA = "0x3D6660", Offset = "0x3D4C60", VA = "0x1803D6660")]
			[CompilerGenerated]
			readonly get
			{
				return RTCAudioStatus.Unsupported;
			}
			[Token(Token = "0x6000E72")]
			[Address(RVA = "0x4DE4A0", Offset = "0x4DCAA0", VA = "0x1804DE4A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E73 RID: 3699 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x4DE690", Offset = "0x4DCC90", VA = "0x1804DE690")]
		internal void Set(ref ParticipantUpdatedCallbackInfoInternal other)
		{
		}
	}
}
