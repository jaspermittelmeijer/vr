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


struct t2122698;
struct t2122698_marshaled;

extern "C" void t2122698_marshal(const t2122698& unmarshaled, t2122698_marshaled& marshaled);
extern "C" void t2122698_marshal_back(const t2122698_marshaled& marshaled, t2122698& unmarshaled);
extern "C" void t2122698_marshal_cleanup(t2122698_marshaled& marshaled);
