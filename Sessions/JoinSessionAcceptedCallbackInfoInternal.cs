using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	internal struct JoinSessionAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinSessionAcceptedCallbackInfo>, ISettable<JoinSessionAcceptedCallbackInfo>, IDisposable
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E7")]
		public object ClientData
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x4BE2C0", Offset = "0x4BC8C0", VA = "0x1804BE2C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x4BE3B0", Offset = "0x4BC9B0", VA = "0x1804BE3B0")]
			set
			{
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x170001E8")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E9")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x4BE330", Offset = "0x4BC930", VA = "0x1804BE330")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x4BE410", Offset = "0x4BCA10", VA = "0x1804BE410")]
			set
			{
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0000398C File Offset: 0x00001B8C
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001EA")]
		public ulong UiEventId
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			set
			{
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x4BE0E0", Offset = "0x4BC6E0", VA = "0x1804BE0E0", Slot = "6")]
		public void Set(ref JoinSessionAcceptedCallbackInfo other)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x4BE1A0", Offset = "0x4BC7A0", VA = "0x1804BE1A0", Slot = "7")]
		public void Set(ref JoinSessionAcceptedCallbackInfo? other)
		{
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x4BE060", Offset = "0x4BC660", VA = "0x1804BE060", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x4BE0C0", Offset = "0x4BC6C0", VA = "0x1804BE0C0", Slot = "5")]
		public void Get(out JoinSessionAcceptedCallbackInfo output)
		{
		}

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x10")]
		private ulong m_UiEventId;
	}
}
