using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	internal struct OnMessageToServerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnMessageToServerCallbackInfo>, ISettable<OnMessageToServerCallbackInfo>, IDisposable
	{
		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002DFB RID: 11771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA3")]
		public object ClientData
		{
			[Token(Token = "0x6002DFA")]
			[Address(RVA = "0x578E20", Offset = "0x577420", VA = "0x180578E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DFB")]
			[Address(RVA = "0x578F10", Offset = "0x577510", VA = "0x180578F10")]
			set
			{
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x0000BE64 File Offset: 0x0000A064
		[Token(Token = "0x17000DA4")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6002DFC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x0000BE7C File Offset: 0x0000A07C
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA5")]
		public ArraySegment<byte> MessageData
		{
			[Token(Token = "0x6002DFD")]
			[Address(RVA = "0x578E90", Offset = "0x577490", VA = "0x180578E90")]
			get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002DFE")]
			[Address(RVA = "0x578F70", Offset = "0x577570", VA = "0x180578F70")]
			set
			{
			}
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x578C40", Offset = "0x577240", VA = "0x180578C40", Slot = "6")]
		public void Set(ref OnMessageToServerCallbackInfo other)
		{
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x578D10", Offset = "0x577310", VA = "0x180578D10", Slot = "7")]
		public void Set(ref OnMessageToServerCallbackInfo? other)
		{
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x578BC0", Offset = "0x5771C0", VA = "0x180578BC0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E02")]
		[Address(RVA = "0x578C20", Offset = "0x577220", VA = "0x180578C20", Slot = "5")]
		public void Get(out OnMessageToServerCallbackInfo output)
		{
		}

		// Token: 0x04001477 RID: 5239
		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04001478 RID: 5240
		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_MessageData;

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x10")]
		private uint m_MessageDataSizeBytes;
	}
}
