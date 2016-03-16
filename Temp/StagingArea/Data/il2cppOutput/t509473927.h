#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t1886596500;
struct t3644373756;
struct t3227571696;

#include "t3012272455.h"
#include "t1588175760.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t509473927  : public t3012272455
{
public:
	t1886596500 * f2;
	t3644373756 * f3;
	t3227571696* f4;
	t1588175760  f5;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t509473927, f2)); }
	inline t1886596500 * fg2() const { return f2; }
	inline t1886596500 ** fag2() { return &f2; }
	inline void fs2(t1886596500 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t509473927, f3)); }
	inline t3644373756 * fg3() const { return f3; }
	inline t3644373756 ** fag3() { return &f3; }
	inline void fs3(t3644373756 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t509473927, f4)); }
	inline t3227571696* fg4() const { return f4; }
	inline t3227571696** fag4() { return &f4; }
	inline void fs4(t3227571696* value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t509473927, f5)); }
	inline t1588175760  fg5() const { return f5; }
	inline t1588175760 * fag5() { return &f5; }
	inline void fs5(t1588175760  value)
	{
		f5 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
