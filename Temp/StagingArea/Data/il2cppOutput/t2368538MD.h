#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>


#include "codegen/il2cpp-codegen.h"


struct t2368538;
struct t2368538_marshaled;

extern "C" void t2368538_marshal(const t2368538& unmarshaled, t2368538_marshaled& marshaled);
extern "C" void t2368538_marshal_back(const t2368538_marshaled& marshaled, t2368538& unmarshaled);
extern "C" void t2368538_marshal_cleanup(t2368538_marshaled& marshaled);
