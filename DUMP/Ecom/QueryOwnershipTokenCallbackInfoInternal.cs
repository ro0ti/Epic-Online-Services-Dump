using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200058C RID: 1420
	[Token(Token = "0x200058C")]
	internal struct QueryOwnershipTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipTokenCallbackInfo>, ISettable<QueryOwnershipTokenCallbackInfo>, IDisposable
	{
		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002494 RID: 9364 RVA: 0x000098CC File Offset: 0x00007ACC
		// (set) Token: 0x06002495 RID: 9365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AA2")]
		public Result ResultCode
		{
			[Token(Token = "0x6002494")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002495")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002497 RID: 9367 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AA3")]
		public object ClientData
		{
			[Token(Token = "0x6002496")]
			[Address(RVA = "0x54E6F0", Offset = "0x54CCF0", VA = "0x18054E6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002497")]
			[Address(RVA = "0x54E850", Offset = "0x54CE50", VA = "0x18054E850")]
			set
			{
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002498 RID: 9368 RVA: 0x000098E4 File Offset: 0x00007AE4
		[Token(Token = "0x17000AA4")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002498")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AA5")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002499")]
			[Address(RVA = "0x54E760", Offset = "0x54CD60", VA = "0x18054E760")]
			get
			{
				return null;
			}
			[Token(Token = "0x600249A")]
			[Address(RVA = "0x54E8B0", Offset = "0x54CEB0", VA = "0x18054E8B0")]
			set
			{
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AA6")]
		public Utf8String OwnershipToken
		{
			[Token(Token = "0x600249B")]
			[Address(RVA = "0x54E7E0", Offset = "0x54CDE0", VA = "0x18054E7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600249C")]
			[Address(RVA = "0x54E910", Offset = "0x54CF10", VA = "0x18054E910")]
			set
			{
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x54E470", Offset = "0x54CA70", VA = "0x18054E470", Slot = "6")]
		public void Set(ref QueryOwnershipTokenCallbackInfo other)
		{
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x54E570", Offset = "0x54CB70", VA = "0x18054E570", Slot = "7")]
		public void Set(ref QueryOwnershipTokenCallbackInfo? other)
		{
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600249F")]
		[Address(RVA = "0x54E3E0", Offset = "0x54C9E0", VA = "0x18054E3E0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024A0")]
		[Address(RVA = "0x54E450", Offset = "0x54CA50", VA = "0x18054E450", Slot = "5")]
		public void Get(out QueryOwnershipTokenCallbackInfo output)
		{
		}

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_OwnershipToken;
	}
}
