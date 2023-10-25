using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public struct PresenceChangedCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000504")]
		public object ClientData
		{
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001311")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000505")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001312")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001313")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000506")]
		public EpicAccountId PresenceUserId
		{
			[Token(Token = "0x6001314")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001315")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x4FAE70", Offset = "0x4F9470", VA = "0x1804FAE70")]
		internal void Set(ref PresenceChangedCallbackInfoInternal other)
		{
		}
	}
}
