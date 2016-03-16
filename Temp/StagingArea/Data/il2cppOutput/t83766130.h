#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t4012695102;
struct t880701411;

#include "t3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t83766130  : public t3012272455
{
public:
	t4012695102 * f2;
	t4012695102 * f3;
	t4012695102 * f4;
	t880701411 * f5;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t83766130, f2)); }
	inline t4012695102 * fg2() const { return f2; }
	inline t4012695102 ** fag2() { return &f2; }
	inline void fs2(t4012695102 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}

	inline static int32_t fog3() { return static_cast<int32_t>(offsetof(t83766130, f3)); }
	inline t4012695102 * fg3() const { return f3; }
	inline t4012695102 ** fag3() { return &f3; }
	inline void fs3(t4012695102 * value)
	{
		f3 = value;
		Il2CppCodeGenWriteBarrier(&f3, value);
	}

	inline static int32_t fog4() { return static_cast<int32_t>(offsetof(t83766130, f4)); }
	inline t4012695102 * fg4() const { return f4; }
	inline t4012695102 ** fag4() { return &f4; }
	inline void fs4(t4012695102 * value)
	{
		f4 = value;
		Il2CppCodeGenWriteBarrier(&f4, value);
	}

	inline static int32_t fog5() { return static_cast<int32_t>(offsetof(t83766130, f5)); }
	inline t880701411 * fg5() const { return f5; }
	inline t880701411 ** fag5() { return &f5; }
	inline void fs5(t880701411 * value)
	{
		f5 = value;
		Il2CppCodeGenWriteBarrier(&f5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
