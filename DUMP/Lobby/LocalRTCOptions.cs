using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	public struct LocalRTCOptions
	{
		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00007EBC File Offset: 0x000060BC
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000806")]
		public uint Flags
		{
			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001C33")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00007ED4 File Offset: 0x000060D4
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000807")]
		public bool UseManualAudioInput
		{
			[Token(Token = "0x6001C34")]
			[Address(RVA = "0x4AFB10", Offset = "0x4AE110", VA = "0x1804AFB10")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C35")]
			[Address(RVA = "0x4AFB60", Offset = "0x4AE160", VA = "0x1804AFB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00007EEC File Offset: 0x000060EC
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000808")]
		public bool UseManualAudioOutput
		{
			[Token(Token = "0x6001C36")]
			[Address(RVA = "0x4AFB40", Offset = "0x4AE140", VA = "0x1804AFB40")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C37")]
			[Address(RVA = "0x4AFB90", Offset = "0x4AE190", VA = "0x1804AFB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00007F04 File Offset: 0x00006104
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000809")]
		public bool LocalAudioDeviceInputStartsMuted
		{
			[Token(Token = "0x6001C38")]
			[Address(RVA = "0x52D840", Offset = "0x52BE40", VA = "0x18052D840")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C39")]
			[Address(RVA = "0x52D850", Offset = "0x52BE50", VA = "0x18052D850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x52D720", Offset = "0x52BD20", VA = "0x18052D720")]
		internal void Set(ref LocalRTCOptionsInternal other)
		{
		}
	}
}
