using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D3 RID: 1747
	[Token(Token = "0x20006D3")]
	internal struct LogPlayerTickOptionsInternal : ISettable<LogPlayerTickOptions>, IDisposable
	{
		// Token: 0x17000D3B RID: 3387
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D3B")]
		public IntPtr PlayerHandle
		{
			[Token(Token = "0x6002CB6")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D3C")]
		public Vec3f? PlayerPosition
		{
			[Token(Token = "0x6002CB7")]
			[Address(RVA = "0x5763A0", Offset = "0x5749A0", VA = "0x1805763A0")]
			set
			{
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D3D")]
		public Quat? PlayerViewRotation
		{
			[Token(Token = "0x6002CB8")]
			[Address(RVA = "0x576410", Offset = "0x574A10", VA = "0x180576410")]
			set
			{
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (set) Token: 0x06002CB9 RID: 11449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D3E")]
		public bool IsPlayerViewZoomed
		{
			[Token(Token = "0x6002CB9")]
			[Address(RVA = "0x576340", Offset = "0x574940", VA = "0x180576340")]
			set
			{
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D3F")]
		public float PlayerHealth
		{
			[Token(Token = "0x6002CBA")]
			[Address(RVA = "0x3E4030", Offset = "0x3E2630", VA = "0x1803E4030")]
			set
			{
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D40")]
		public AntiCheatCommonPlayerMovementState PlayerMovementState
		{
			[Token(Token = "0x6002CBB")]
			[Address(RVA = "0x3D2EA0", Offset = "0x3D14A0", VA = "0x1803D2EA0")]
			set
			{
			}
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x575FF0", Offset = "0x5745F0", VA = "0x180575FF0", Slot = "4")]
		public void Set(ref LogPlayerTickOptions other)
		{
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x576140", Offset = "0x574740", VA = "0x180576140", Slot = "5")]
		public void Set(ref LogPlayerTickOptions? other)
		{
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x575F80", Offset = "0x574580", VA = "0x180575F80", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013DA RID: 5082
		[Token(Token = "0x40013DA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013DB RID: 5083
		[Token(Token = "0x40013DB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlayerHandle;

		// Token: 0x040013DC RID: 5084
		[Token(Token = "0x40013DC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PlayerPosition;

		// Token: 0x040013DD RID: 5085
		[Token(Token = "0x40013DD")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_PlayerViewRotation;

		// Token: 0x040013DE RID: 5086
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0x20")]
		private int m_IsPlayerViewZoomed;

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0x24")]
		private float m_PlayerHealth;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0x28")]
		private AntiCheatCommonPlayerMovementState m_PlayerMovementState;
	}
}
