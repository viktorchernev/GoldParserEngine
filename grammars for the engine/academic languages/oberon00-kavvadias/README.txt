
----------------------------------------------------
-- Oberon-00 grammar for the GOLD parser          --
----------------------------------------------------
-- Author: Nikolaos Kavvadias                     --
--         Ph.D. Student                          --
--                                                --
--         Electronics Lab                        --
--         Department of Physics                  --
--         Aristotle University of Thessaloniki   --
--         Thessaloniki                           --
--         54124, GREECE                          --
--                                                --
-- Contact:                                       --
--         <nkavv@skiathos.physics.auth.gr>       --
--         <kaveirious@yahoo.com>                 --
----------------------------------------------------

-- 1. INTRODUCTION

Oberon-00 is a simple programming language proposed in [Wirth98] (see
reference below) as a simple example of a common language that can be
used for hardware and software compilation. Such language could be
used for research purposes in the field of high-level synthesis (HLS)
and as a testbed for hardware-software codesign. Oberon-00 is derived
as a hardware-friendly subset of Oberon.

This package contains both a regular BNF grammar derived from the
Oberon-00 EBNF, which can be used within the GOLD parser environment
and the original EBNF.


-- 2. FILES IN PACKAGE

oberon00.grm           The GOLD parser grammar for Oberon-00
oberon00.cgt           Compiled tables for oberon00.grm
oberon00.ebnf          An EBNF for Oberon-00
first.obr              Example program 1
log.obr                  -#-     -#-   2
minmax.obr               -#-     -#-   3
multiply.obr             -#-     -#-   4
second.obr               -#-     -#-   5
README                 This file


-- 3. VERSION HISTORY

+ Version: 0.1.a                                             31/10/2004
    * Translated the Oberon-00 EBNF to a regular BNF in the GOLD parser
      style.


-- 4. REFERENCES

@ARTICLE{Wirth98,
  author = {Niklaus Wirth},
  month = {June},
  year = 1998,
  title = {Hardware Compilation: Translating Programs into Circuits},
  journal = {IEEE Computer},
  volume = 31,
  number = 6,
  pages = {25--31},
  keywords = {unified programming language, Pascal language, Oberon
  language, high-level synthesis, hardware compilation, Oberon-00
  language}
}


