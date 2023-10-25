using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	public struct AudioBuffer
	{
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000306")]
		public short[] Frames
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00004664 File Offset: 0x00002864
		// (set) Token: 0x06000CC6 RID: 3270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000307")]
		public uint SampleRate
		{
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0000467C File Offset: 0x0000287C
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000308")]
		public uint Channels
		{
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x4D5BA0", Offset = "0x4D41A0", VA = "0x1804D5BA0")]
		internal void Set(ref AudioBufferInternal other)
		{
		}
	}
}
