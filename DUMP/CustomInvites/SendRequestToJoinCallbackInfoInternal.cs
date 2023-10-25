using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	internal struct SendRequestToJoinCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendRequestToJoinCallbackInfo>, ISettable<SendRequestToJoinCallbackInfo>, IDisposable
	{
		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x060026BE RID: 9918 RVA: 0x00009E24 File Offset: 0x00008024
		// (set) Token: 0x060026BF RID: 9919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B3F")]
		public Result ResultCode
		{
			[Token(Token = "0x60026BE")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60026BF")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026C1 RID: 9921 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B40")]
		public object ClientData
		{
			[Token(Token = "0x60026C0")]
			[Address(RVA = "0x567D20", Offset = "0x566320", VA = "0x180567D20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026C1")]
			[Address(RVA = "0x567E90", Offset = "0x566490", VA = "0x180567E90")]
			set
			{
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x00009E3C File Offset: 0x0000803C
		[Token(Token = "0x17000B41")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60026C2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026C4 RID: 9924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B42")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026C3")]
			[Address(RVA = "0x567D90", Offset = "0x566390", VA = "0x180567D90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026C4")]
			[Address(RVA = "0x567EF0", Offset = "0x5664F0", VA = "0x180567EF0")]
			set
			{
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026C6 RID: 9926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B43")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60026C5")]
			[Address(RVA = "0x567E10", Offset = "0x566410", VA = "0x180567E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026C6")]
			[Address(RVA = "0x567F50", Offset = "0x566550", VA = "0x180567F50")]
			set
			{
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x567AA0", Offset = "0x5660A0", VA = "0x180567AA0", Slot = "6")]
		public void Set(ref SendRequestToJoinCallbackInfo other)
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026C8")]
		[Address(RVA = "0x567BA0", Offset = "0x5661A0", VA = "0x180567BA0", Slot = "7")]
		public void Set(ref SendRequestToJoinCallbackInfo? other)
		{
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026C9")]
		[Address(RVA = "0x567A10", Offset = "0x566010", VA = "0x180567A10", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026CA")]
		[Address(RVA = "0x567A80", Offset = "0x566080", VA = "0x180567A80", Slot = "5")]
		public void Get(out SendRequestToJoinCallbackInfo output)
		{
		}

		// Token: 0x040010F7 RID: 4343
		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040010F8 RID: 4344
		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040010F9 RID: 4345
		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x040010FA RID: 4346
		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
