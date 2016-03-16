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


struct t214874643;
struct t214874643_marshaled;

extern "C" void t214874643_marshal(const t214874643& unmarshaled, t214874643_marshaled& marshaled);
extern "C" void t214874643_marshal_back(const t214874643_marshaled& marshaled, t214874643& unmarshaled);
extern "C" void t214874643_marshal_cleanup(t214874643_marshaled& marshaled);
