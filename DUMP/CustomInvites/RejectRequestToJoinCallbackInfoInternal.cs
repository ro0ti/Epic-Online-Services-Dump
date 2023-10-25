using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D4 RID: 1492
	[Token(Token = "0x20005D4")]
	internal struct RejectRequestToJoinCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectRequestToJoinCallbackInfo>, ISettable<RejectRequestToJoinCallbackInfo>, IDisposable
	{
		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002635 RID: 9781 RVA: 0x00009C74 File Offset: 0x00007E74
		// (set) Token: 0x06002636 RID: 9782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B08")]
		public Result ResultCode
		{
			[Token(Token = "0x6002635")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6002636")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002637 RID: 9783 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002638 RID: 9784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B09")]
		public object ClientData
		{
			[Token(Token = "0x6002637")]
			[Address(RVA = "0x5653B0", Offset = "0x5639B0", VA = "0x1805653B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002638")]
			[Address(RVA = "0x565520", Offset = "0x563B20", VA = "0x180565520")]
			set
			{
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002639 RID: 9785 RVA: 0x00009C8C File Offset: 0x00007E8C
		[Token(Token = "0x17000B0A")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002639")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600263B RID: 9787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B0B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600263A")]
			[Address(RVA = "0x565420", Offset = "0x563A20", VA = "0x180565420")]
			get
			{
				return null;
			}
			[Token(Token = "0x600263B")]
			[Address(RVA = "0x565580", Offset = "0x563B80", VA = "0x180565580")]
			set
			{
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B0C")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600263C")]
			[Address(RVA = "0x5654A0", Offset = "0x563AA0", VA = "0x1805654A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600263D")]
			[Address(RVA = "0x5655E0", Offset = "0x563BE0", VA = "0x1805655E0")]
			set
			{
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600263E")]
		[Address(RVA = "0x5652B0", Offset = "0x5638B0", VA = "0x1805652B0", Slot = "6")]
		public void Set(ref RejectRequestToJoinCallbackInfo other)
		{
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600263F")]
		[Address(RVA = "0x565130", Offset = "0x563730", VA = "0x180565130", Slot = "7")]
		public void Set(ref RejectRequestToJoinCallbackInfo? other)
		{
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002640")]
		[Address(RVA = "0x5650A0", Offset = "0x5636A0", VA = "0x1805650A0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002641")]
		[Address(RVA = "0x565110", Offset = "0x563710", VA = "0x180565110", Slot = "5")]
		public void Get(out RejectRequestToJoinCallbackInfo output)
		{
		}

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
