#pragma once

#include "targetver.h"

#include <stdio.h>
#include <tchar.h>
#include <utility>
#include <vector>
#include <random>
#include <memory>
#include <algorithm>
#include <iostream>

using std::pair;
using std::vector;
using std::uniform_int_distribution;
using std::default_random_engine;
using std::unique_ptr;
using std::make_unique;
using std::cout;

extern default_random_engine dre;
