using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	internal struct DestroyLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<DestroyLobbyCallbackInfo>, ISettable<DestroyLobbyCallbackInfo>, IDisposable
	{
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x000071E4 File Offset: 0x000053E4
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000700")]
		public Result ResultCode
		{
			[Token(Token = "0x6001927")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001928")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000701")]
		public object ClientData
		{
			[Token(Token = "0x6001929")]
			[Address(RVA = "0x50A140", Offset = "0x508740", VA = "0x18050A140")]
			get
			{
				return null;
			}
			[Token(Token = "0x600192A")]
			[Address(RVA = "0x50A220", Offset = "0x508820", VA = "0x18050A220")]
			set
			{
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x000071FC File Offset: 0x000053FC
		[Token(Token = "0x17000702")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600192B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000703")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x600192C")]
			[Address(RVA = "0x50A1B0", Offset = "0x5087B0", VA = "0x18050A1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600192D")]
			[Address(RVA = "0x50A280", Offset = "0x508880", VA = "0x18050A280")]
			set
			{
			}
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x509F60", Offset = "0x508560", VA = "0x180509F60", Slot = "6")]
		public void Set(ref DestroyLobbyCallbackInfo other)
		{
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x50A020", Offset = "0x508620", VA = "0x18050A020", Slot = "7")]
		public void Set(ref DestroyLobbyCallbackInfo? other)
		{
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x509EE0", Offset = "0x5084E0", VA = "0x180509EE0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x509F40", Offset = "0x508540", VA = "0x180509F40", Slot = "5")]
		public void Get(out DestroyLobbyCallbackInfo output)
		{
		}

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
