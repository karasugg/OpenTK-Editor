﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace OpenTKEditor
{
    class Cube : Object3D
    {
        public Cube(float size)
        {
            _vertexBuffer = new Vector3[] {
                new Vector3(-size, -size,  -size),
                new Vector3(size, -size,  -size),
                new Vector3(size, size,  -size),
                new Vector3(-size, size,  -size),
                new Vector3(-size, -size,  size),
                new Vector3(size, -size,  size),
                new Vector3(size, size,  size),
                new Vector3(-size, size,  size),
            };

            _indexBuffer = new int[]{
                //left
                0, 2, 1,
                0, 3, 2,
                //back
                1, 2, 6,
                6, 5, 1,
                //right
                4, 5, 6,
                6, 7, 4,
                //top
                2, 3, 6,
                6, 3, 7,
                //front
                0, 7, 3,
                0, 4, 7,
                //bottom
                0, 1, 5,
                0, 5, 4
            };
            _colorBuffer = new Vector3[] 
            {
                new Vector3( 0.5f, 0.5f, 0.5f),
                new Vector3( 0.25f, 0.25f, 0.5f),
                new Vector3( 0.25f, 0.5f, 0.5f),
                new Vector3( 0.5f, 0.25f, 0.5f),
                new Vector3( 0.25f, 0.25f, 0.5f),
                new Vector3( 0.5f, 0.5f, 0.5f),
                new Vector3( 0.25f, 0.25f, 0.5f),
                new Vector3( 0.5f, 0.5f, 0.5f),
            };
            InitializeBuffers();
        }        
    }
}
