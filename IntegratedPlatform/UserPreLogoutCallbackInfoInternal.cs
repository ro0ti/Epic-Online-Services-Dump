using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004F5 RID: 1269
	[Token(Token = "0x20004F5")]
	internal struct UserPreLogoutCallbackInfoInternal : ICallbackInfoInternal, IGettable<UserPreLogoutCallbackInfo>, ISettable<UserPreLogoutCallbackInfo>, IDisposable
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700093C")]
		public object ClientData
		{
			[Token(Token = "0x600208D")]
			[Address(RVA = "0x552680", Offset = "0x550C80", VA = "0x180552680")]
			get
			{
				return null;
			}
			[Token(Token = "0x600208E")]
			[Address(RVA = "0x5528B0", Offset = "0x550EB0", VA = "0x1805528B0")]
			set
			{
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x00008C0C File Offset: 0x00006E0C
		[Token(Token = "0x1700093D")]
		public IntPtr ClientDataAddress
		{
			[Token(Token = "0x600208F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002091 RID: 8337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700093E")]
		public Utf8String PlatformType
		{
			[Token(Token = "0x6002090")]
			[Address(RVA = "0x552760", Offset = "0x550D60", VA = "0x180552760")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002091")]
			[Address(RVA = "0x552970", Offset = "0x550F70", VA = "0x180552970")]
			set
			{
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06002092 RID: 8338 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002093 RID: 8339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700093F")]
		public Utf8String LocalPlatformUserId
		{
			[Token(Token = "0x6002092")]
			[Address(RVA = "0x5526F0", Offset = "0x550CF0", VA = "0x1805526F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002093")]
			[Address(RVA = "0x552910", Offset = "0x550F10", VA = "0x180552910")]
			set
			{
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000940")]
		public EpicAccountId AccountId
		{
			[Token(Token = "0x6002094")]
			[Address(RVA = "0x552600", Offset = "0x550C00", VA = "0x180552600")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002095")]
			[Address(RVA = "0x552850", Offset = "0x550E50", VA = "0x180552850")]
			set
			{
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002097 RID: 8343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000941")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x5527D0", Offset = "0x550DD0", VA = "0x1805527D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x5529D0", Offset = "0x550FD0", VA = "0x1805529D0")]
			set
			{
			}
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x552270", Offset = "0x550870", VA = "0x180552270", Slot = "6")]
		public void Set(ref UserPreLogoutCallbackInfo other)
		{
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x5523F0", Offset = "0x5509F0", VA = "0x1805523F0", Slot = "7")]
		public void Set(ref UserPreLogoutCallbackInfo? other)
		{
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x5521C0", Offset = "0x5507C0", VA = "0x1805521C0", Slot = "8")]
		public void Dispose()
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x552240", Offset = "0x550840", VA = "0x180552240", Slot = "5")]
		public void Get(out UserPreLogoutCallbackInfo output)
		{
		}

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x0")]
		private IntPtr m_ClientData;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlatformType;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalPlatformUserId;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_AccountId;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x20")]
		private IntPtr m_ProductUserId;
	}
}
