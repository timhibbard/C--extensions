{\rtf1\ansi\ansicpg1252\cocoartf1138
{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural

\f0\fs24 \cf0     public static class ListHelper\
    \{\
        public static List<T> ThinOut<T>(this List<T> source, int MaxItems)\
        \{\
            //source already less than max items\
            if (source.Count < MaxItems)\
            \{\
                return source;\
            \}\
\
            int multiplier = (source.Count / MaxItems);\
\
            //since multiplier is an int, it will round down\
            //ie: 179/100 would equal 1\
            //this wouldn't work well, so up it by 1\
            multiplier++;\
\
            List<T> rv = new List<T>();\
\
            //pull out every X item, as specified by the multiplier\
            //and add that to a new list\
            for (int i = 0; i < source.Count; i = i + multiplier)\
            \{\
                rv.Add(source[i]);\
            \}\
\
            return rv;\
        \}\
    \}}