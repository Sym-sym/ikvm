﻿/*
  Copyright (C) 2007-2011 Jeroen Frijters

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

  Jeroen Frijters
  jeroen@frijters.net
  
*/

namespace IKVM.Runtime.Vfs
{

    /// <summary>
    /// Describes a link to an executable path. Provides a method to obtain actual executable path.
    /// </summary>
    abstract class VfsExecutable : VfsFile
    {

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="context"></param>
        public VfsExecutable(VfsContext context) :
            base(context)
        {

        }

        /// <summary>
        /// Gets the size of the executable file.
        /// </summary>
        public override long Size => 0;

        /// <summary>
        /// Gets the underlying path to the executable.
        /// </summary>
        /// <returns></returns>
        public abstract string GetLink();

    }

}
