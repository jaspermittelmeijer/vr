#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

struct t4012695102;

#include "t3012272455.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

struct  t319835859  : public t3012272455
{
public:
	t4012695102 * f2;

public:
	inline static int32_t fog2() { return static_cast<int32_t>(offsetof(t319835859, f2)); }
	inline t4012695102 * fg2() const { return f2; }
	inline t4012695102 ** fag2() { return &f2; }
	inline void fs2(t4012695102 * value)
	{
		f2 = value;
		Il2CppCodeGenWriteBarrier(&f2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
