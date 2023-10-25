using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006C3 RID: 1731
	[Token(Token = "0x20006C3")]
	internal struct LogEventParamPairInternal : IGettable<LogEventParamPair>, ISettable<LogEventParamPair>, IDisposable
	{
		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x0000B18C File Offset: 0x0000938C
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE9")]
		public LogEventParamPairParamValue ParamValue
		{
			[Token(Token = "0x6002C0B")]
			[Address(RVA = "0x571C60", Offset = "0x570260", VA = "0x180571C60")]
			get
			{
				return default(LogEventParamPairParamValue);
			}
			[Token(Token = "0x6002C0C")]
			[Address(RVA = "0x571CF0", Offset = "0x5702F0", VA = "0x180571CF0")]
			set
			{
			}
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x571AA0", Offset = "0x5700A0", VA = "0x180571AA0", Slot = "5")]
		public void Set(ref LogEventParamPair other)
		{
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x571B40", Offset = "0x570140", VA = "0x180571B40", Slot = "6")]
		public void Set(ref LogEventParamPair? other)
		{
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C0F")]
		[Address(RVA = "0x571A10", Offset = "0x570010", VA = "0x180571A10", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x571A70", Offset = "0x570070", VA = "0x180571A70", Slot = "4")]
		public void Get(out LogEventParamPair output)
		{
		}

		// Token: 0x04001381 RID: 4993
		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x0")]
		private LogEventParamPairParamValueInternal m_ParamValue;
	}
}
