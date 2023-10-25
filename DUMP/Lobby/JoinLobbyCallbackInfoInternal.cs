using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003D2 RID: 978
	[Token(Token = "0x20003D2")]
	internal struct JoinLobbyCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyCallbackInfo>, ISettable<JoinLobbyCallbackInfo>, IDisposable
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x000073DC File Offset: 0x000055DC
		// (set) Token: 0x060019CC RID: 6604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000746")]
		public Result ResultCode
		{
			[Token(Token = "0x60019CB")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019CE RID: 6606 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000747")]
		public object ClientData
		{
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x50F0E0", Offset = "0x50D6E0", VA = "0x18050F0E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019CE")]
			[Address(RVA = "0x50F1C0", Offset = "0x50D7C0", VA = "0x18050F1C0")]
			set
			{
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x000073F4 File Offset: 0x000055F4
		[Token(Token = "0x17000748")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60019CF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000749")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60019D0")]
			[Address(RVA = "0x50F150", Offset = "0x50D750", VA = "0x18050F150")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019D1")]
			[Address(RVA = "0x50F220", Offset = "0x50D820", VA = "0x18050F220")]
			set
			{
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x50F020", Offset = "0x50D620", VA = "0x18050F020", Slot = "6")]
		public void Set(ref JoinLobbyCallbackInfo other)
		{
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x50EF00", Offset = "0x50D500", VA = "0x18050EF00", Slot = "7")]
		public void Set(ref JoinLobbyCallbackInfo? other)
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x50EE80", Offset = "0x50D480", VA = "0x18050EE80", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x50EEE0", Offset = "0x50D4E0", VA = "0x18050EEE0", Slot = "5")]
		public void Get(out JoinLobbyCallbackInfo output)
		{
		}

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x04000BA1 RID: 2977
		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x04000BA2 RID: 2978
		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
