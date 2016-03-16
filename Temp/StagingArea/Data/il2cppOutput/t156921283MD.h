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


struct t156921283;
struct t156921283_marshaled;

extern "C" void t156921283_marshal(const t156921283& unmarshaled, t156921283_marshaled& marshaled);
extern "C" void t156921283_marshal_back(const t156921283_marshaled& marshaled, t156921283& unmarshaled);
extern "C" void t156921283_marshal_cleanup(t156921283_marshaled& marshaled);
