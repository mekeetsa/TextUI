﻿/* --------------------------------------------------------------------------------------
 *  KTH ID132V Laboration 4
 *  MbkCommons Library
 * --------------------------------------------------------------------------------------
 *  Namespace:  Mbk.Commons
 *  File:       StringLogicalComparer.cs
 *  Created:    2011-04-27
 *  Modified:   2011-04-27
 * --------------------------------------------------------------------------------------
 *  Author:     Vasian Cepa
 *  Optimized:  Richard Deeming
 *  Modified:   Mikica B Kocic
 *  License:    No explicit; assummed Creative Commons - GNU General Public License 
 *              http://www.codeproject.com/KB/recipes/csnsort.aspx?msg=1183262
 *              Copyright (c) 2005 by Vasian Cepa
 * --------------------------------------------------------------------------------------
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mbk.Commons
{
    /// <remarks>
    /// Optimized by Richard Deeming, Original code by Vasian Cepa
    /// For comments see:
    ///     http://www.codeproject.com/KB/recipes/csnsort.aspx?msg=1183262
    /// </remarks>
    /// 
    public static class StringLogicalComparer
    {
        /// <summary>
        /// Logically compares two strings where numbers in string contents are compared 
        /// as numbers and text as text.
        /// </summary>
        /// 
        public static int Compare( string s1, string s2 )
        {
            if ( null == s1 || 0 == s1.Length )
            {
                if ( null == s2 || 0 == s2.Length ) return 0;
                return -1;
            }
            else if ( null == s2 || 0 == s2.Length )
            {
                return +1;
            }

            int s1Length = s1.Length;
            int s2Length = s2.Length;

            bool sp1 = char.IsLetterOrDigit( s1[ 0 ] );
            bool sp2 = char.IsLetterOrDigit( s2[ 0 ] );

            if ( sp1 && ! sp2 ) return +1;
            if ( ! sp1 && sp2 ) return -1;

            int i1 = 0, i2 = 0;
            int r = 0;

            while ( true )
            {
                char c1 = s1[ i1 ];
                char c2 = s2[ i2 ];

                sp1 = char.IsDigit( c1 );
                sp2 = char.IsDigit( c2 );

                if ( ! sp1 && ! sp2 )
                {
                    if ( c1 != c2 )
                    {
                        bool letter1 = char.IsLetter( c1 );
                        bool letter2 = char.IsLetter( c2 );

                        if ( letter1 && letter2 )
                        {
                            c1 = char.ToUpper( c1 );
                            c2 = char.ToUpper( c2 );

                            r = c1 - c2;
                            if ( 0 != r ) return r;
                        }
                        else if ( !letter1 && !letter2 )
                        {
                            r = c1 - c2;
                            if ( 0 != r ) return r;
                        }
                        else if ( letter1 )
                        {
                            return +1;
                        }
                        else if ( letter2 )
                        {
                            return -1;
                        }
                    }

                }
                else if ( sp1 && sp2 )
                {
                    r = CompareNumbers( s1, s1Length, ref i1, s2, s2Length, ref i2 );
                    if ( 0 != r ) return r;
                }
                else if ( sp1 )
                {
                    return -1;
                }
                else if ( sp2 )
                {
                    return +1;
                }

                i1++;
                i2++;

                if ( i1 >= s1Length )
                {
                    if ( i2 >= s2Length ) return 0;
                    return -1;
                }
                else if ( i2 >= s2Length )
                {
                    return +1;
                }
            }
        }

        #region [ Private Methods ]

        private static int CompareNumbers (
            string s1, int s1Length, ref int i1,
            string s2, int s2Length, ref int i2 )
        {
            int nzStart1 = i1, nzStart2 = i2;
            int end1 = i1, end2 = i2;

            ScanNumber( s1, s1Length, i1, ref nzStart1, ref end1 );
            ScanNumber( s2, s2Length, i2, ref nzStart2, ref end2 );

            int start1 = i1;
            i1 = end1 - 1;
            int start2 = i2;
            i2 = end2 - 1;

            int length1 = end2 - nzStart2;
            int length2 = end1 - nzStart1;

            if ( length1 == length2 )
            {
                int r;
                for ( int j1 = nzStart1, j2 = nzStart2; j1 <= i1; j1++, j2++ )
                {
                    r = s1[ j1 ] - s2[ j2 ];
                    if ( 0 != r ) return r;
                }

                length1 = end1 - start1;
                length2 = end2 - start2;

                if ( length1 == length2 ) return 0;
            }

            return length1 > length2 ? -1 : +1;
        }

        private static void ScanNumber ( 
            string s, int length, int start, 
            ref int nzStart, ref int end )
        {
            nzStart = start;
            end = start;

            bool countZeros = true;
            char c = s[ end ];

            while ( true )
            {
                if ( countZeros )
                {
                    if ( '0' == c )
                    {
                        nzStart++;
                    }
                    else
                    {
                        countZeros = false;
                    }
                }

                end++;
                if ( end >= length ) break;

                c = s[ end ];
                if ( !char.IsDigit( c ) ) break;
            }
        }

        #endregion
    }
}