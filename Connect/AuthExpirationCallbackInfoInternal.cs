using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	internal struct AuthExpirationCallbackInfoInternal : ICallbackInfoInternal, IGettable<AuthExpirationCallbackInfo>, ISettable<AuthExpirationCallbackInfo>, IDisposable
	{
		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B4E")]
		public object ClientData
		{
			[Token(Token = "0x60026E9")]
			[Address(RVA = "0x553190", Offset = "0x551790", VA = "0x180553190")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026EA")]
			[Address(RVA = "0x553280", Offset = "0x551880", VA = "0x180553280")]
			set
			{
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x00009E6C File Offset: 0x0000806C
		[Token(Token = "0x17000B4F")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60026EB")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x060026EC RID: 9964 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060026ED RID: 9965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B50")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60026EC")]
			[Address(RVA = "0x553200", Offset = "0x551800", VA = "0x180553200")]
			get
			{
				return null;
			}
			[Token(Token = "0x60026ED")]
			[Address(RVA = "0x5532E0", Offset = "0x5518E0", VA = "0x1805532E0")]
			set
			{
			}
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026EE")]
		[Address(RVA = "0x552FE0", Offset = "0x5515E0", VA = "0x180552FE0", Slot = "6")]
		public void Set(ref AuthExpirationCallbackInfo other)
		{
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x553090", Offset = "0x551690", VA = "0x180553090", Slot = "7")]
		public void Set(ref AuthExpirationCallbackInfo? other)
		{
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026F0")]
		[Address(RVA = "0x552F60", Offset = "0x551560", VA = "0x180552F60", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60026F1")]
		[Address(RVA = "0x552FC0", Offset = "0x5515C0", VA = "0x180552FC0", Slot = "5")]
		public void Get(out AuthExpirationCallbackInfo output)
		{
		}

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
