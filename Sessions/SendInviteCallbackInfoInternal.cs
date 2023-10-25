using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	internal struct SendInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendInviteCallbackInfo>, ISettable<SendInviteCallbackInfo>, IDisposable
	{
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000220")]
		public Result ResultCode
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			set
			{
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000221")]
		public object ClientData
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x4C5E00", Offset = "0x4C4400", VA = "0x1804C5E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x4C5E70", Offset = "0x4C4470", VA = "0x1804C5E70")]
			set
			{
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[Token(Token = "0x17000222")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x4C5DA0", Offset = "0x4C43A0", VA = "0x1804C5DA0", Slot = "6")]
		public void Set(ref SendInviteCallbackInfo other)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x4C5CE0", Offset = "0x4C42E0", VA = "0x1804C5CE0", Slot = "7")]
		public void Set(ref SendInviteCallbackInfo? other)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x4C5C70", Offset = "0x4C4270", VA = "0x1804C5C70", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x4C5CC0", Offset = "0x4C42C0", VA = "0x1804C5CC0", Slot = "5")]
		public void Get(out SendInviteCallbackInfo output)
		{
		}

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x0")]
		private Result m_ResultCode;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientData;
	}
}
