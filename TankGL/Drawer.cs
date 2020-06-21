using System;
using SharpGL;

namespace TankGL
{
    public class Drawer
    {
        public void DrawParallelepiped(OpenGL gl, float x, float y, float z, float widthX, float widthY, float widthZ)
        {
            gl.Begin(OpenGL.GL_QUADS);

            // bottom facet
            gl.Normal(0.0f, -1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(x, y, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(x, y, z + widthZ);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(x + widthX, y, z + widthZ);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(x + widthX, y, z);


            // top facet
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(x, y + widthY, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(x, y + widthY, z + widthZ);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(x + widthX, y + widthY, z + widthZ);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(x + widthX, y + widthY, z);

            // right facet
            gl.Normal(0.0f, 0.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(x, y, z + widthZ);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(x + widthX, y, z + widthZ);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(x + widthX, y + widthY, z + widthZ);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(x, y + widthY, z + widthZ);

            // left facet
            gl.Normal(0.0f, 0.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(x, y, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(x + widthX, y, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(x + widthX, y + widthY, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(x, y + widthY, z);

            // back facet
            gl.Normal(1.0f, 0.0f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(x + widthX, y, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(x + widthX, y, z + widthZ);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(x + widthX, y + widthY, z + widthZ);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(x + widthX, y + widthY, z);

            // front facet
            gl.Normal(-1.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(x, y, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(x, y, z + widthZ);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(x, y + widthY, z + widthZ);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(x, y + widthY, z);

            gl.End();
        }

        public void DrawCylinder(OpenGL gl, float x, float y, float radius, float height, float step)
        {
            var angle = 0.0f;
            // facets of cylinder
            gl.Begin(OpenGL.GL_QUAD_STRIP);

            while (angle < 2 * Math.PI)
            {
                gl.Normal(Math.Cos(angle), 1.0f, Math.Sin(angle));
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(angle));
                gl.TexCoord(angle / (Math.PI), 1.0f);
                gl.Vertex(x, y, height);
                gl.TexCoord(angle / (Math.PI), 0.0f);
                gl.Vertex(x, y, 0.0);
                angle += step;
            }
            gl.Vertex(radius, 0.0f, height);
            gl.Vertex(radius, 0.0f, 0.0f);
            gl.End();

            //top circle
            DrawCircle(gl, x, y, 0.0f, radius, step);
            //bottom circle
            DrawCircle(gl, x, y, height, radius, step);
        }

        public void DrawCircle(OpenGL gl, float x, float y, float height, float radius, float step)
        {
            var angle = 0.0f;
            gl.Begin(OpenGL.GL_POLYGON);
            while (angle < (float)(2 * Math.PI))
            {
                x = (float)(radius * Math.Cos(angle));
                y = (float)(radius * Math.Sin(angle));
                gl.TexCoord(x / radius * 0.5f + 0.5f, y / radius * 0.5f + 0.5f);
                gl.Vertex(x, y, height);
                angle += step;
            }
            gl.Vertex(radius, 0.0f, height);
            gl.End();
        }
    }
}