using SharpGL;

namespace TankGL
{
    public class DrawTank
    {
        private readonly Drawer drawer = new Drawer();

        public void DrawAllParts(OpenGL gl)
        {
            DrawLowerHull(gl);
            DrawUpperHull(gl);
            DrawChassis(gl);
        }

        private void DrawLowerHull(OpenGL gl)
        {
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[1]);
            DrawBottomLowerHull(gl);

            //top lower hull
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            drawer.DrawParallelepiped(gl, 0.212f, 0.056f, 0.0f, 1.192f, 0.2f, 0.744f);

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            DrowFrontLowerHull(gl);
        }

        private void DrawBottomLowerHull(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);

            // bottom facet
            gl.Normal(0.0f, -1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.744f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(1.36f, 0.0f, 0.744f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(1.36f, 0.0f, 0.0f);

            // right facet
            gl.Normal(0.0f, 0.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 0.744f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(1.36f, 0.0f, 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(1.404f, 0.056f, 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, 0.744f);

            // left facet
            gl.Normal(0.0f, 0.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(1.36f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(1.404f, 0.056f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.0f);

            // front facet
            gl.Normal(-1.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.0f, 0.0f, 0.744f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.744f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.0f);

            // back facet
            gl.Normal(1.0f, 0.0f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(1.36f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(1.36f, 0.0f, 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(1.404f, 0.056f, 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(1.404f, 0.056f, 0.0f);

            // top facet
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(1.404f, 0.056f, 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(1.404f, 0.056f, 0.0f);

            gl.End();
        }

        private void DrowFrontLowerHull(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);

            // bottom facet
            gl.Normal(0.0f, -1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.212f, 0.056f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.212f, 0.056f, 0.744f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.744f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.0f);

            // right facet
            gl.Normal(0.0f, 0.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.212f, 0.056f, 0.744f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.212f, 0.256f, 0.744f);

            // left facet
            gl.Normal(0.0f, 0.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.212f, 0.056f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.212f, 0.256f, 0.0f);

            // back facet
            gl.Normal(1.0f, 0.0f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.212f, 0.056f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.212f, 0.056f, 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.212f, 0.256f, 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.212f, 0.256f, 0.0f);

            // front facet
            gl.Normal(-1.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, 0.744f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, 0.744f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, 0.0f);

            // top facet
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.212f, 0.256f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.212f, 0.256f, 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, 0.0f);

            gl.End();
        }

        private void DrawUpperHull(OpenGL gl)
        {
            //bottom upper hull
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            drawer.DrawParallelepiped(gl, 0.792f, 0.256f, 0.0f, 0.612f, 0.02f, 0.744f);

            DrawArmouredSkirt(gl);

            //base of turret
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            drawer.DrawParallelepiped(gl, 0.212f, 0.256f, -0.148f, 0.58f, 0.104f, 1.04f);

            //base of spare track
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            drawer.DrawParallelepiped(gl, 0.792f, 0.276f, 0.0f, 0.124f, 0.056f, 0.744f);

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[19]);
            gl.Begin(OpenGL.GL_QUADS);
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.792f, 0.276f + 0.0561f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.792f, 0.276f + 0.0561f, 0.0f + 0.744f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.792f + 0.124f, 0.276f + 0.0561f, 0.0f + 0.744f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.792f + 0.124f, 0.276f + 0.0561f, 0.0f);
            gl.End();

            //box
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[14]);
            drawer.DrawParallelepiped(gl, 0.112f, 0.232f, 0.512f, 0.1f, 0.128f, 0.192f);

            DrawTurret(gl);

            DrawMainGun(gl);

            DrawMuffler(gl);
        }

        private void DrawArmouredSkirt(OpenGL gl)
        {
            DrawOneSkirt(gl, -0.148f);
            DrawOneSkirt(gl, 0.744f);
        }

        private void DrawOneSkirt(OpenGL gl, float z)
        {
            //front skirt
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            drawer.DrawParallelepiped(gl, -0.248f, 0.246f, z, 0.46f, 0.01f, 0.148f);

            gl.PushMatrix();
            gl.Translate(-0.091, -0.257, z);
            gl.Rotate(30, 0.0f, 0.0f, 1.0f);
            gl.Translate(0.091, 0.257, -z);
            drawer.DrawParallelepiped(gl, -0.091f, 0.257f, z, 0.12f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(-0.361, 0.106, z);
            gl.Rotate(80, 0.0f, 0.0f, 1.0f);
            gl.Translate(0.361, -0.106, -z);
            drawer.DrawParallelepiped(gl, -0.361f, 0.106f, z, 0.09f, 0.01f, 0.148f);
            gl.PopMatrix();

            //back skirt
            drawer.DrawParallelepiped(gl, 0.792f, 0.246f, z, 0.66f, 0.01f, 0.148f);

            gl.PushMatrix();
            gl.Translate(1.535f, 0.172, z);
            gl.Rotate(135, 0.0f, 0.0f, 1.0f);
            gl.Translate(-1.535f, -0.172, -z);
            drawer.DrawParallelepiped(gl, 1.535f, 0.172f, z, 0.12f, 0.01f, 0.148f);
            gl.PopMatrix();

            DrawBetweenHullAndChassis(gl, 0.0f);
            DrawBetweenHullAndChassis(gl, 0.744f);
        }

        private void DrawBetweenHullAndChassis(OpenGL gl, float z)
        {

            double zWidth;

            zWidth = z - 0.005f;
            if (z > 0)
                zWidth = z - 0.01f;

            gl.Begin(OpenGL.GL_QUADS);
            // bottom facet
            gl.Normal(0.0f, -1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.212f, 0.256f, zWidth);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.212f, 0.256f, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, zWidth);

            // top facet
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.212f, 0.256f, zWidth);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.212f, 0.256f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, zWidth);

            // right facet
            gl.Normal(0.0f, 0.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(0.212f, 0.255f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(0.212f, 0.256f, z);

            // left facet
            gl.Normal(0.0f, 0.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(0.212f, 0.255f, zWidth);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, zWidth);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, zWidth);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(0.212f, 0.256f, zWidth);

            // front facet
            gl.Normal(-1.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, zWidth);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, zWidth);
            gl.End();

            gl.Begin(OpenGL.GL_QUADS);
            // bottom facet
            gl.Normal(0.0f, -1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.148f, zWidth);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.148f, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, zWidth);

            // top facet
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.256f, zWidth);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.256f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, zWidth);

            // right facet
            gl.Normal(0.0f, 0.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, z);

            // left facet
            gl.Normal(0.0f, 0.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.148f, zWidth);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, zWidth);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.354f, 0.196f, zWidth);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.256f, zWidth);

            // back facet
            gl.Normal(1.0f, 0.0f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, zWidth);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.148f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.256f, zWidth);

            // front facet
            gl.Normal(-1.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, zWidth);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.268f, 0.195f, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, zWidth);
            gl.End();


            gl.Begin(OpenGL.GL_QUADS);

            // bottom facet
            gl.Normal(0.0f, -1.0f, 0.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, zWidth);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, zWidth);

            // top facet
            gl.Normal(0.0f, 1.0f, 0.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.354f, 0.196f, zWidth);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.354f, 0.196f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.369f, 0.106f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.369f, 0.106f, zWidth);

            // back facet
            gl.Normal(1.0f, 0.0f, 0.0f);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, zWidth);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, zWidth);

            // front facet
            gl.Normal(-1.0f, 0.0f, 0.0f);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, zWidth);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.369f, 0.106f, z);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.369f, 0.106f, zWidth);

            // right facet
            gl.Normal(0.0f, 0.0f, 1.0f);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.268f, 0.144f, z);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.248f, 0.056f, z);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.369f, 0.106f, z);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.354f, 0.196f, z);

            // left facet
            gl.Normal(0.0f, 0.0f, -1.0f);
            gl.TexCoord(1.0f, 1.0f);
            gl.Vertex(-0.268f, 0.144f, zWidth);
            gl.TexCoord(0.0f, 1.0f);
            gl.Vertex(-0.248f, 0.056f, zWidth);
            gl.TexCoord(0.0f, 0.0f);
            gl.Vertex(-0.369f, 0.106f, zWidth);
            gl.TexCoord(1.0f, 0.0f);
            gl.Vertex(-0.354f, 0.196f, zWidth);
            gl.End();
        }

        private void DrawTurret(OpenGL gl)
        {
            //turret
            gl.PushMatrix();
            gl.Rotate(90.0, 1.0f, 0.0f, 0.0f);
            gl.Translate(0.502, 0.36, -0.56);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[15]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.424f / 2, 0.2f, 0.1f);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[6]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.424f / 2, 0.1f);
            gl.PopMatrix();

            //back of turret
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[4]);
            drawer.DrawParallelepiped(gl, 0.565f, 0.41f, 0.168f, 0.248f, 0.149f, 0.374f);

            //panorama on turret
            gl.PushMatrix();
            gl.Rotate(90.0, 1.0f, 0.0f, 0.0f);
            gl.Translate(0.415, 0.47, -0.61);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.038f, 0.07f, 0.1f);
            gl.PopMatrix();
        }

        private void DrawMainGun(OpenGL gl)
        {
            //barrel
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[16]);
            gl.PushMatrix();
            gl.Rotate(0.0, 1.0f, 0.0f, 0.0f);
            gl.Rotate(90.0, 0.0f, 1.0f, 0.0f);
            gl.Translate(-0.36, 0.47, -0.234);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.016f, 0.516f, 0.1f);
            gl.PopMatrix();

            //muzzle brake
            gl.PushMatrix();
            gl.Rotate(0.0, 1.0f, 0.0f, 0.0f);
            gl.Rotate(90.0, 0.0f, 1.0f, 0.0f);
            gl.Translate(-0.36, 0.47, -0.234);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[18]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.019f, 0.018f, 0.1f);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[17]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, -0.001f, 0.019f, 0.1f);
            gl.PopMatrix();

            //base of barrel
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            gl.PushMatrix();
            gl.Rotate(0.0, 1.0f, 0.0f, 0.0f);
            gl.Rotate(90.0, 0.0f, 1.0f, 0.0f);
            gl.Translate(-0.36, 0.47, 0.228);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.023f, 0.041f, 0.1f);
            gl.PopMatrix();

            //ejector
            gl.PushMatrix();
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[0]);
            gl.Rotate(0.0, 1.0f, 0.0f, 0.0f);
            gl.Rotate(90.0, 0.0f, 1.0f, 0.0f);
            gl.Translate(-0.36, 0.47, 0.145);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.018f, 0.124f, 0.1f);
            gl.PopMatrix();

            DrawMantlet(gl);
        }

        private void DrawMantlet(OpenGL gl)
        {
            gl.PushMatrix();
            gl.Translate(0.348, 0.46, 0.245);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[15]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.16f / 2, 0.232f, 0.1f);
            gl.PopMatrix();
        }

        private void DrawMuffler(OpenGL gl)
        {
            gl.PushMatrix();
            gl.Translate(1.434, 0.352, 0.05);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[3]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.152f / 2, 0.644f, 0.1f);


            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[5]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.152f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.644f, 0.152f / 2, 0.1f);

            gl.PopMatrix();
        }

        private void DrawChassis(OpenGL gl)
        {
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[2]);
            DrawTracks(gl);

            DrawWheels(gl);
        }

        private void DrawTracks(OpenGL gl)
        {
            DrawTrack(gl, -0.152f);
            DrawTrack(gl, 0.748f);
        }

        private void DrawTrack(OpenGL gl, float z)
        {
            // top, bottom tracks
            for (int i = 0; i < 1.62 / 0.044; i++)
                drawer.DrawParallelepiped(gl, -0.24f + i * 0.044f, 0.23f - 0.0009f * i, z, 0.04f, 0.01f, 0.148f);
            for (int i = 0; i < 1.16 / 0.044; i++)
                drawer.DrawParallelepiped(gl, 0.016f + i * 0.044f, -0.066f, z, 0.04f, 0.01f, 0.148f);

            //front tracks
            gl.PushMatrix();
            gl.Translate(-0.179, -0.005, z);
            gl.Rotate(35, 0.0f, 0.0f, 1.0f);
            gl.Translate(0.179, 0.005, -z);
            for (int i = 0; i < 0.08 / 0.0449; i++)
                drawer.DrawParallelepiped(gl, -0.179f + (i * 0.0449f), 0.221f, z, 0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(-0.301, 0.097, z);
            gl.Rotate(98, 0.0f, 0.0f, 1.0f);
            gl.Translate(0.301, -0.097, -z);
            for (int i = 0; i < 0.07 / 0.0449; i++)
                drawer.DrawParallelepiped(gl, -0.301f + (i * 0.0449f), 0.097f, z, 0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(-0.281, 0.057, z);
            gl.Rotate(120, 0.0f, 0.0f, 1.0f);
            gl.Translate(0.281, -0.057, -z);
            drawer.DrawParallelepiped(gl, -0.281f, 0.057f, z, 0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(0.008, -0.068, z);
            gl.Rotate(160, 0.0f, 0.0f, 1.0f);
            gl.Translate(-0.008, 0.068, -z);
            for (int i = 0; i < 0.282 / 0.0449; i++)
                drawer.DrawParallelepiped(gl, 0.008f + (i * 0.0451f), -0.081f, z, 0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            //back tracks
            gl.PushMatrix();
            gl.Translate(1.455, 0.148, z);
            gl.Rotate(-35, 0.0f, 0.0f, 1.0f);
            gl.Translate(-1.455, -0.148, -z);
            for (int i = 0; i < 0.08 / 0.0449; i++)
                drawer.DrawParallelepiped(gl, 1.455f - (i * 0.0449f), 0.148f, z, -0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(1.468, 0.148, z);
            gl.Rotate(87, 0.0f, 0.0f, 1.0f);
            gl.Translate(-1.468, -0.148, -z);
            for (int i = 0; i < 0.08 / 0.044; i++)
                drawer.DrawParallelepiped(gl, 1.468f - (i * 0.044f), 0.148f, z, -0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(1.461, 0.061, z);
            gl.Rotate(73, 0.0f, 0.0f, 1.0f);
            gl.Translate(-1.461, -0.061, -z);
            drawer.DrawParallelepiped(gl, 1.461f, 0.061f, z, -0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(1.448, 0.021, z);
            gl.Rotate(27, 0.0f, 0.0f, 1.0f);
            gl.Translate(-1.448, -0.021, -z);
            drawer.DrawParallelepiped(gl, 1.448f, 0.021f, z, -0.04f, 0.01f, 0.148f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(1.203, -0.056, z);
            gl.Rotate(-162, 0.0f, 0.0f, 1.0f);
            gl.Translate(-1.203, 0.056, -z);
            for (int i = 0; i < 0.2 / 0.0449; i++)
                drawer.DrawParallelepiped(gl, 1.203f - (i * 0.044f), -0.056f, z, -0.04f, 0.01f, 0.148f);
            gl.PopMatrix();
        }

        private void DrawWheels(OpenGL gl)
        {
            DrawBigWheelsOnSide(gl, -0.147f);
            DrawBigWheelsOnSide(gl, 0.743f);

            DrawSmallWheelsOnSide(gl, -0.117f);
            DrawSmallWheelsOnSide(gl, 0.743f);
        }

        private void DrawBigWheelsOnSide(OpenGL gl, float z)
        {
            //wheel axle
            gl.PushMatrix();
            gl.Translate(-0.21, 0.131, z);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[4]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.1f / 2, 0.138f, 0.1f);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[11]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.1f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.138f, 0.1f / 2, 0.1f);
            gl.PopMatrix();

            //first wheel
            gl.PushMatrix();
            gl.Translate(-0.21, 0.131, z + 0.015);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[11]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.2f / 2, 0.02f, 0.1f);
            gl.PopMatrix();

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[10]);
            gl.PushMatrix();
            gl.Translate(-0.21, 0.131, z + 0.015);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.2f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.02f, 0.2f / 2, 0.1f);
            gl.PopMatrix();

            //second wheel
            gl.PushMatrix();
            gl.Translate(-0.21, 0.131, z + 0.108);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[11]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.2f / 2, 0.02f, 0.1f);
            gl.PopMatrix();

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[10]);
            gl.PushMatrix();
            gl.Translate(-0.21, 0.131, z + 0.108);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.2f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.02f, 0.2f / 2, 0.1f);
            gl.PopMatrix();

            for (int i = 0; i < 4; i++)
            {
                //wheel axle
                gl.PushMatrix();
                gl.Translate(0.04 + i * 0.35, 0.04, z);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[4]);
                drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.05f / 2, 0.138f, 0.1f);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[8]);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.05f / 2, 0.1f);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.138f, 0.05f / 2, 0.1f);
                gl.PopMatrix();

                //first wheel
                gl.PushMatrix();
                gl.Translate(0.04 + i * 0.35, 0.04, z + 0.035);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[9]);
                drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.19f / 2, 0.02f, 0.1f);
                gl.PopMatrix();

                gl.PushMatrix();
                gl.Translate(0.04 + i * 0.35, 0.04, z + 0.035);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[7]);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.19f / 2, 0.1f);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.02f, 0.19f / 2, 0.1f);
                gl.PopMatrix();

                //second wheel
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[9]);
                gl.PushMatrix();
                gl.Translate(0.04 + i * 0.35, 0.04, z + 0.068);
                drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.19f / 2, 0.02f, 0.1f);
                gl.PopMatrix();

                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[7]);
                gl.PushMatrix();
                gl.Translate(0.04 + i * 0.35, 0.04, z + 0.068);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.19f / 2, 0.1f);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.02f, 0.19f / 2, 0.1f);
                gl.PopMatrix();
            }


            //wheel axle
            gl.PushMatrix();
            gl.Translate(-0.04 + 0.35 * 4, 0.1, z);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[4]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.04f / 2, 0.138f, 0.1f);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[8]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.04f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.138f, 0.04f / 2, 0.1f);
            gl.PopMatrix();

            //first wheel
            gl.PushMatrix();
            gl.Translate(-0.04 + 0.35 * 4, 0.1, z + 0.025);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[9]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.2f / 2, 0.03f, 0.1f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(-0.04 + 0.35 * 4, 0.1, z + 0.025);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[12]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.2f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.03f, 0.2f / 2, 0.1f);
            gl.PopMatrix();

            //second wheel
            gl.PushMatrix();
            gl.Translate(-0.04 + 0.35 * 4, 0.1, z + 0.098);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[9]);
            drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.2f / 2, 0.03f, 0.1f);
            gl.PopMatrix();

            gl.PushMatrix();
            gl.Translate(-0.04 + 0.35 * 4, 0.1, z + 0.098);
            gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[12]);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.0f, 0.2f / 2, 0.1f);
            drawer.DrawCircle(gl, 0.0f, 0.0f, 0.03f, 0.2f / 2, 0.1f);
            gl.PopMatrix();
        }

        private void DrawSmallWheelsOnSide(OpenGL gl, float z)
        {
            double y;
            double zFirst;
            double zSecond;
            for (int i = 0; i < 2; i++)
            {
                y = 0.19;

                if (i != 0)
                    y = 0.183;

                //wheel axle
                gl.PushMatrix();
                gl.Translate(0.215 + i * 0.35, y, z);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[4]);
                drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.04f / 2, 0.087f, 0.1f);
                gl.PopMatrix();

                zFirst = z;
                zSecond = z + 0.035;
                if (z > 0)
                {
                    zFirst = z + 0.035;
                    zSecond = z + 0.065;
                }

                //first wheel
                gl.PushMatrix();
                gl.Translate(0.215 + i * 0.35, y, zFirst);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[9]);
                drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.07f / 2, 0.02f, 0.1f);
                gl.PopMatrix();

                gl.PushMatrix();
                gl.Translate(0.215 + i * 0.35, y, zFirst);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[13]);
                drawer.DrawCircle(gl, 0.0f, 0.0f, -0.001f, 0.07f / 2, 0.1f);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.019f, 0.07f / 2, 0.1f);
                gl.PopMatrix();

                //second wheel
                gl.PushMatrix();
                gl.Translate(0.215 + i * 0.35, y, zSecond);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[9]);
                drawer.DrawCylinder(gl, 0.0f, 0.0f, 0.07f / 2, 0.02f, 0.1f);
                gl.PopMatrix();

                gl.PushMatrix();
                gl.Translate(0.215 + i * 0.35, y, zSecond);
                gl.BindTexture(OpenGL.GL_TEXTURE_2D, TankGL_Form.textures[13]);
                drawer.DrawCircle(gl, 0.0f, 0.0f, -0.001f, 0.07f / 2, 0.1f);
                drawer.DrawCircle(gl, 0.0f, 0.0f, 0.019f, 0.07f / 2, 0.1f);
                gl.PopMatrix();
            }
        }
    }
}