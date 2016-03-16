#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


struct t1562406440;
struct t77292912;

#include "Il2CppArray.h"
#include "t1562406440.h"
#include "t77292912.h"

#pragma once
struct t595823673  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t1562406440 * m_Items[1];

public:
	inline t1562406440 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t1562406440 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t1562406440 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
struct t2525013713  : public Il2CppArray
{
public:
	ALIGN_TYPE (8) t77292912 * m_Items[1];

public:
	inline t77292912 * GetAt(il2cpp_array_size_t index) const { return m_Items[index]; }
	inline t77292912 ** GetAddressAt(il2cpp_array_size_t index) { return m_Items + index; }
	inline void SetAt(il2cpp_array_size_t index, t77292912 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
