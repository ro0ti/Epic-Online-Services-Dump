using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000638 RID: 1592
	[Token(Token = "0x2000638")]
	internal struct QueryProductUserIdMappingsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryProductUserIdMappingsCallbackInfo>, ISettable<QueryProductUserIdMappingsCallbackInfo>, IDisposable
	{
		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060028AB RID: 10411 RVA: 0x0000A3C4 File Offset: 0x000085C4
		// (set) Token: 0x060028AC RID: 10412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC7")]
		public Result ResultCode
		{
			[Token(Token = "0x60028AB")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x60028AC")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060028AD RID: 10413 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028AE RID: 10414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC8")]
		public object ClientData
		{
			[Token(Token = "0x60028AD")]
			[Address(RVA = "0x564B20", Offset = "0x563120", VA = "0x180564B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028AE")]
			[Address(RVA = "0x564C10", Offset = "0x563210", VA = "0x180564C10")]
			set
			{
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x0000A3DC File Offset: 0x000085DC
		[Token(Token = "0x17000BC9")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x60028AF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060028B0 RID: 10416 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028B1 RID: 10417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BCA")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028B0")]
			[Address(RVA = "0x564B90", Offset = "0x563190", VA = "0x180564B90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028B1")]
			[Address(RVA = "0x564C70", Offset = "0x563270", VA = "0x180564C70")]
			set
			{
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x564940", Offset = "0x562F40", VA = "0x180564940", Slot = "6")]
		public void Set(ref QueryProductUserIdMappingsCallbackInfo other)
		{
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x564A00", Offset = "0x563000", VA = "0x180564A00", Slot = "7")]
		public void Set(ref QueryProductUserIdMappingsCallbackInfo? other)
		{
		}

		// Token: 0x060028B4 RID: 10420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x5648C0", Offset = "0x562EC0", VA = "0x1805648C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x564920", Offset = "0x562F20", VA = "0x180564920", Slot = "5")]
		public void Get(out QueryProductUserIdMappingsCallbackInfo output)
		{
		}

		// Token: 0x040011AB RID: 4523
		[Token(Token = "0x40011AB")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x040011AC RID: 4524
		[Token(Token = "0x40011AC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;

		// Token: 0x040011AD RID: 4525
		[Token(Token = "0x40011AD")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
