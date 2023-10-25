using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
// Dumped by ro0ti

namespace Epic.OnlineServices
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public sealed class Helper
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x4A6B90", Offset = "0x4A5190", VA = "0x1804A6B90")]
		internal static void AddCallback(out IntPtr clientDataAddress, object clientData, Delegate publicDelegate, Delegate privateDelegate, params Delegate[] structDelegates)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x4A9020", Offset = "0x4A7620", VA = "0x1804A9020")]
		private static void RemoveCallback(IntPtr clientDataAddress)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		internal static bool TryGetCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(ref TCallbackInfoInternal callbackInfoInternal, out TCallback callback, out TCallbackInfo callbackInfo) where TCallbackInfoInternal : struct, ICallbackInfoInternal, IGettable<TCallbackInfo> where TCallback : class where TCallbackInfo : struct, ICallbackInfo
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000006")]
		internal static bool TryGetAndRemoveCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(ref TCallbackInfoInternal callbackInfoInternal, out TCallback callback, out TCallbackInfo callbackInfo) where TCallbackInfoInternal : struct, ICallbackInfoInternal, IGettable<TCallbackInfo> where TCallback : class where TCallbackInfo : struct, ICallbackInfo
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000007")]
		internal static bool TryGetStructCallback<TCallbackInfoInternal, TCallback, TCallbackInfo>(ref TCallbackInfoInternal callbackInfoInternal, out TCallback callback, out TCallbackInfo callbackInfo) where TCallbackInfoInternal : struct, ICallbackInfoInternal, IGettable<TCallbackInfo> where TCallback : class where TCallbackInfo : struct
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4A8E60", Offset = "0x4A7460", VA = "0x1804A8E60")]
		internal static void RemoveCallbackByNotificationId(ulong notificationId)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4A7330", Offset = "0x4A5930", VA = "0x1804A7330")]
		internal static void AddStaticCallback(string key, Delegate publicDelegate, Delegate privateDelegate)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000A")]
		internal static bool TryGetStaticCallback<TCallback>(string key, out TCallback callback) where TCallback : class
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4A7530", Offset = "0x4A5B30", VA = "0x1804A7530")]
		internal static void AssignNotificationIdToCallback(IntPtr clientDataAddress, ulong notificationId)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020C8 File Offset: 0x000002C8
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4A6D50", Offset = "0x4A5350", VA = "0x1804A6D50")]
		private static IntPtr AddClientData(object clientData)
		{
			return 0;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4A9150", Offset = "0x4A7750", VA = "0x1804A9150")]
		private static void RemoveClientData(IntPtr clientDataAddress)
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4A81E0", Offset = "0x4A67E0", VA = "0x1804A81E0")]
		private static object GetClientData(IntPtr clientDataAddress)
		{
			return null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		private static void Convert<THandle>(IntPtr from, out THandle to) where THandle : Handle, new()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4A77F0", Offset = "0x4A5DF0", VA = "0x1804A77F0")]
		private static void Convert(Handle from, out IntPtr to)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x4A7840", Offset = "0x4A5E40", VA = "0x1804A7840")]
		private static void Convert(byte[] from, out string to)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x4A7700", Offset = "0x4A5D00", VA = "0x1804A7700")]
		private static void Convert(string from, out byte[] to, int fromLength)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		private static void Convert<TArray>(TArray[] from, out int to)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		private static void Convert<TArray>(TArray[] from, out uint to)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		private static void Convert<TArray>(ArraySegment<TArray> from, out int to)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		private static void Convert<T>(ArraySegment<T> from, out uint to)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4A76F0", Offset = "0x4A5CF0", VA = "0x1804A76F0")]
		private static void Convert(int from, out bool to)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4A7960", Offset = "0x4A5F60", VA = "0x1804A7960")]
		private static void Convert(bool from, out int to)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4A7AD0", Offset = "0x4A60D0", VA = "0x1804A7AD0")]
		private static void Convert(DateTimeOffset? from, out long to)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x4A7970", Offset = "0x4A5F70", VA = "0x1804A7970")]
		private static void Convert(long from, out DateTimeOffset? to)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		internal static void Get<TArray>(TArray[] from, out int to)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		internal static void Get<TArray>(TArray[] from, out uint to)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		internal static void Get<TArray>(ArraySegment<TArray> from, out uint to)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001E")]
		internal static void Get<TTo>(IntPtr from, out TTo to) where TTo : Handle, new()
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		internal static void Get<TFrom, TTo>(ref TFrom from, out TTo to) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x4A84B0", Offset = "0x4A6AB0", VA = "0x1804A84B0")]
		internal static void Get(int from, out bool to)
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x4A8580", Offset = "0x4A6B80", VA = "0x1804A8580")]
		internal static void Get(bool from, out int to)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x4A8320", Offset = "0x4A6920", VA = "0x1804A8320")]
		internal static void Get(long from, out DateTimeOffset? to)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		internal static void Get<TTo>(IntPtr from, out TTo[] to, int arrayLength, bool isArrayItemAllocated)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		internal static void Get<TTo>(IntPtr from, out TTo[] to, uint arrayLength, bool isArrayItemAllocated)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		internal static void Get<TTo>(IntPtr from, out TTo[] to, int arrayLength)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		internal static void Get<TTo>(IntPtr from, out TTo[] to, uint arrayLength)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x4A88C0", Offset = "0x4A6EC0", VA = "0x1804A88C0")]
		internal static void Get(IntPtr from, out ArraySegment<byte> to, uint arrayLength)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		internal static void GetHandle<THandle>(IntPtr from, out THandle[] to, uint arrayLength) where THandle : Handle, new()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		internal static void Get<TFrom, TTo>(TFrom[] from, out TTo[] to) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		internal static void Get<TFrom, TTo>(IntPtr from, out TTo[] to, int arrayLength) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		internal static void Get<TFrom, TTo>(IntPtr from, out TTo[] to, uint arrayLength) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		internal static void Get<TTo>(IntPtr from, out TTo? to) where TTo : struct
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x4A85D0", Offset = "0x4A6BD0", VA = "0x1804A85D0")]
		internal static void Get(byte[] from, out string to)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x4A8510", Offset = "0x4A6B10", VA = "0x1804A8510")]
		internal static void Get(IntPtr from, out object to)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x4A8720", Offset = "0x4A6D20", VA = "0x1804A8720")]
		internal static void Get(IntPtr from, out Utf8String to)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		internal static void Get<T, TEnum>(T from, out T to, TEnum currentEnum, TEnum expectedEnum)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		internal static void Get<TFrom, TTo, TEnum>(ref TFrom from, out TTo to, TEnum currentEnum, TEnum expectedEnum) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		internal static void Get<TEnum>(int from, out bool? to, TEnum currentEnum, TEnum expectedEnum)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		internal static void Get<TFrom, TEnum>(TFrom from, out TFrom? to, TEnum currentEnum, TEnum expectedEnum) where TFrom : struct
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		internal static void Get<TFrom, TEnum>(IntPtr from, out TFrom to, TEnum currentEnum, TEnum expectedEnum) where TFrom : Handle, new()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		internal static void Get<TEnum>(IntPtr from, out IntPtr? to, TEnum currentEnum, TEnum expectedEnum)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		internal static void Get<TEnum>(IntPtr from, out Utf8String to, TEnum currentEnum, TEnum expectedEnum)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000037")]
		internal static void Get<TFrom, TTo>(IntPtr from, out TTo to) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		internal static void Get<TFrom, TTo>(IntPtr from, out TTo? to) where TFrom : struct, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		internal static void Get<TFrom, TTo>(ref TFrom from, out TTo to, out IntPtr clientDataAddress) where TFrom : struct, ICallbackInfoInternal, IGettable<TTo> where TTo : struct
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x4A7D90", Offset = "0x4A6390", VA = "0x1804A7D90")]
		public static int GetAllocationCount()
		{
			return 0;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x4A7C00", Offset = "0x4A6200", VA = "0x1804A7C00")]
		internal static void Copy(byte[] from, IntPtr to)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x4A7C80", Offset = "0x4A6280", VA = "0x1804A7C80")]
		internal static void Copy(ArraySegment<byte> from, IntPtr to)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x4A7D30", Offset = "0x4A6330", VA = "0x1804A7D30")]
		internal static void Dispose(ref IntPtr value)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003E")]
		internal static void Dispose<TDisposable>(ref TDisposable disposable) where TDisposable : IDisposable
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		internal static void Dispose<TEnum>(ref IntPtr value, TEnum currentEnum, TEnum expectedEnum)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4A8190", Offset = "0x4A6790", VA = "0x1804A8190")]
		private static int GetAnsiStringLength(byte[] bytes)
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x4A8120", Offset = "0x4A6720", VA = "0x1804A8120")]
		private static int GetAnsiStringLength(IntPtr address)
		{
			return 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000020DE File Offset: 0x000002DE
		[Token(Token = "0x6000042")]
		internal static T GetDefault<T>()
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		private static void GetAllocation<T>(IntPtr source, out T target)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		private static void GetAllocation<T>(IntPtr source, out T? target) where T : struct
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		private static void GetAllocation<THandle>(IntPtr source, out THandle[] target, int arrayLength) where THandle : Handle, new()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		private static void GetAllocation<T>(IntPtr from, out T[] to, int arrayLength, bool isArrayItemAllocated)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4A7FB0", Offset = "0x4A65B0", VA = "0x1804A7FB0")]
		private static void GetAllocation(IntPtr source, out Utf8String target)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4A69A0", Offset = "0x4A4FA0", VA = "0x1804A69A0")]
		internal static IntPtr AddAllocation(int size)
		{
			return 0;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x4A6950", Offset = "0x4A4F50", VA = "0x1804A6950")]
		internal static IntPtr AddAllocation(uint size)
		{
			return 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600004A")]
		private static IntPtr AddAllocation<T>(int size, T cache)
		{
			return 0;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x600004B")]
		private static IntPtr AddAllocation<T>(int size, T[] cache, bool? isArrayItemAllocated)
		{
			return 0;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600004C")]
		private static IntPtr AddAllocation<T>(T[] array, bool isArrayItemAllocated)
		{
			return 0;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x4A89A0", Offset = "0x4A6FA0", VA = "0x1804A89A0")]
		private static void RemoveAllocation(ref IntPtr address)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4A9B40", Offset = "0x4A8140", VA = "0x1804A9B40")]
		private static bool TryGetAllocationCache(IntPtr address, out object cache)
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4A7030", Offset = "0x4A5630", VA = "0x1804A7030")]
		private static IntPtr AddPinnedBuffer(byte[] buffer, int offset)
		{
			return 0;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4A6EC0", Offset = "0x4A54C0", VA = "0x1804A6EC0")]
		private static IntPtr AddPinnedBuffer(Utf8String str)
		{
			return 0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4A6F40", Offset = "0x4A5540", VA = "0x1804A6F40")]
		internal static IntPtr AddPinnedBuffer(ArraySegment<byte> array)
		{
			return 0;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4A9270", Offset = "0x4A7870", VA = "0x1804A9270")]
		private static void RemovePinnedBuffer(ref IntPtr address)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		internal static void Set<T>(ref T from, ref T to) where T : struct
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4A9A80", Offset = "0x4A8080", VA = "0x1804A9A80")]
		internal static void Set(object from, ref IntPtr to)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4A97F0", Offset = "0x4A7DF0", VA = "0x1804A97F0")]
		internal static void Set(Utf8String from, ref IntPtr to)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4A94E0", Offset = "0x4A7AE0", VA = "0x1804A94E0")]
		internal static void Set(Handle from, ref IntPtr to)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		internal static void Set<T>(T? from, ref IntPtr to) where T : struct
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		internal static void Set<T>(T[] from, ref IntPtr to, bool isArrayItemAllocated)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4A9560", Offset = "0x4A7B60", VA = "0x1804A9560")]
		internal static void Set(ArraySegment<byte> from, ref IntPtr to, out uint arrayLength)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		internal static void Set<T>(T[] from, ref IntPtr to)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		internal static void Set<T>(T[] from, ref IntPtr to, bool isArrayItemAllocated, out int arrayLength)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		internal static void Set<T>(T[] from, ref IntPtr to, bool isArrayItemAllocated, out uint arrayLength)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		internal static void Set<T>(T[] from, ref IntPtr to, out int arrayLength)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		internal static void Set<T>(T[] from, ref IntPtr to, out uint arrayLength)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4A9900", Offset = "0x4A7F00", VA = "0x1804A9900")]
		internal static void Set(DateTimeOffset? from, ref long to)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4A9AF0", Offset = "0x4A80F0", VA = "0x1804A9AF0")]
		internal static void Set(bool from, ref int to)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4A96D0", Offset = "0x4A7CD0", VA = "0x1804A96D0")]
		internal static void Set(string from, ref byte[] to, int stringLength)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		internal static void Set<T, TEnum>(T from, ref T to, TEnum fromEnum, ref TEnum toEnum, [Optional] IDisposable disposable)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		internal static void Set<TFrom, TEnum, TTo>(ref TFrom from, ref TTo to, TEnum fromEnum, ref TEnum toEnum, [Optional] IDisposable disposable) where TFrom : struct where TTo : struct, ISettable<TFrom>
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		internal static void Set<T, TEnum>(T? from, ref T to, TEnum fromEnum, ref TEnum toEnum, [Optional] IDisposable disposable) where T : struct
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		internal static void Set<TEnum>(Handle from, ref IntPtr to, TEnum fromEnum, ref TEnum toEnum, [Optional] IDisposable disposable)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		internal static void Set<TEnum>(Utf8String from, ref IntPtr to, TEnum fromEnum, ref TEnum toEnum, [Optional] IDisposable disposable)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		internal static void Set<TEnum>(bool? from, ref int to, TEnum fromEnum, ref TEnum toEnum, [Optional] IDisposable disposable)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		internal static void Set<TFrom, TIntermediate>(ref TFrom from, ref IntPtr to) where TFrom : struct where TIntermediate : struct, ISettable<TFrom>
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		internal static void Set<TFrom, TIntermediate>(ref TFrom? from, ref IntPtr to) where TFrom : struct where TIntermediate : struct, ISettable<TFrom>
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		internal static void Set<TFrom, TTo>(ref TFrom from, ref TTo to) where TFrom : struct where TTo : struct, ISettable<TFrom>
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		internal static void Set<TFrom, TIntermediate>(ref TFrom[] from, ref IntPtr to, out int arrayLength) where TFrom : struct where TIntermediate : struct, ISettable<TFrom>
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		internal static void Set<TFrom, TIntermediate>(ref TFrom[] from, ref IntPtr to, out uint arrayLength) where TFrom : struct where TIntermediate : struct, ISettable<TFrom>
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x3E4E80", Offset = "0x3E3480", VA = "0x1803E4E80")]
		public Helper()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<IntPtr, Helper.Allocation> s_Allocations;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<IntPtr, Helper.PinnedBuffer> s_PinnedBuffers;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<IntPtr, Helper.DelegateHolder> s_Callbacks;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Helper.DelegateHolder> s_StaticCallbacks;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static long s_LastClientDataId;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Dictionary<IntPtr, object> s_ClientDatas;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		private struct Allocation
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00002204 File Offset: 0x00000404
			// (set) Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000001")]
			public int Size
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6000070")]
				[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000071 RID: 113 RVA: 0x000020DE File Offset: 0x000002DE
			// (set) Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000002")]
			public object Cache
			{
				[Token(Token = "0x6000071")]
				[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000072")]
				[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000073 RID: 115 RVA: 0x0000221C File Offset: 0x0000041C
			// (set) Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000003")]
			public bool? IsArrayItemAllocated
			{
				[Token(Token = "0x6000073")]
				[Address(RVA = "0x487740", Offset = "0x485D40", VA = "0x180487740")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000074")]
				[Address(RVA = "0x487770", Offset = "0x485D70", VA = "0x180487770")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x4876F0", Offset = "0x485CF0", VA = "0x1804876F0")]
			public Allocation(int size, object cache, [Optional] bool? isArrayItemAllocated)
			{
			}
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		private struct PinnedBuffer
		{
			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00002234 File Offset: 0x00000434
			// (set) Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000004")]
			public GCHandle Handle
			{
				[Token(Token = "0x6000076")]
				[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
				[CompilerGenerated]
				readonly get
				{
					return default(GCHandle);
				}
				[Token(Token = "0x6000077")]
				[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000078 RID: 120 RVA: 0x0000224C File Offset: 0x0000044C
			// (set) Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000005")]
			public int RefCount
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6000079")]
				[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x4ACD90", Offset = "0x4AB390", VA = "0x1804ACD90")]
			public PinnedBuffer(GCHandle handle)
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		private class DelegateHolder
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000020DE File Offset: 0x000002DE
			// (set) Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000006")]
			public Delegate Public
			{
				[Token(Token = "0x600007B")]
				[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600007D RID: 125 RVA: 0x000020DE File Offset: 0x000002DE
			// (set) Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000007")]
			public Delegate Private
			{
				[Token(Token = "0x600007D")]
				[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600007E")]
				[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600007F RID: 127 RVA: 0x000020DE File Offset: 0x000002DE
			// (set) Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000008")]
			public Delegate[] StructDelegates
			{
				[Token(Token = "0x600007F")]
				[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000080")]
				[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000081 RID: 129 RVA: 0x00002264 File Offset: 0x00000464
			// (set) Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000009")]
			public ulong? NotificationId
			{
				[Token(Token = "0x6000081")]
				[Address(RVA = "0x4A17B0", Offset = "0x49FDB0", VA = "0x1804A17B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000082")]
				[Address(RVA = "0x4A17C0", Offset = "0x49FDC0", VA = "0x1804A17C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x4A1740", Offset = "0x49FD40", VA = "0x1804A1740")]
			public DelegateHolder(Delegate publicDelegate, Delegate privateDelegate, params Delegate[] structDelegates)
			{
			}
		}
	}
}
