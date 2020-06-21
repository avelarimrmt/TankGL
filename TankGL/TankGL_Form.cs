using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph;

namespace TankGL
{
    public partial class TankGL_Form : Form
    {
        public TankGL_Form()
        {
            InitializeComponent();
        }

        public static uint[] textures;

        private GLColor white = new GLColor(1, 1, 1, 1);
        private GLColor black = new GLColor(0, 0, 0, 0);

        private void OpenGLControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            var gl = openGLControl1.OpenGL;
            gl.ClearColor(0.6f, 0.6f, 0.6f, 0.1f);

            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_DIFFUSE, white);
            gl.Light(OpenGL.GL_LIGHT1, OpenGL.GL_AMBIENT, black);
            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, black);
            gl.Enable(OpenGL.GL_LIGHT1);
            gl.Enable(OpenGL.GL_LIGHTING);

            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_AMBIENT, new[] { 1.0f, 1.0f, 1.0f });
            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_DIFFUSE, new[] { 1.0f, 1.0f, 1.0f });
            gl.Light(OpenGL.GL_LIGHT2, OpenGL.GL_POSITION, new[] { 0.0f, 1.0f, 0.0f });
            gl.Enable(OpenGL.GL_LIGHT2);

            gl.Material(OpenGL.GL_FRONT_AND_BACK, OpenGL.GL_DIFFUSE, white);

            textures = new uint[19];
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            gl.GenTextures(19, textures);

            GenerateTexture(0, @"..\..\textures\hull.bmp");
            GenerateTexture(1, @"..\..\textures\hull_lower.bmp");
            GenerateTexture(2, @"..\..\textures\track.bmp");
            GenerateTexture(3, @"..\..\textures\muffler.bmp");
            GenerateTexture(4, @"..\..\textures\turret.bmp");
            GenerateTexture(5, @"..\..\textures\muffler_circles.bmp");
            GenerateTexture(6, @"..\..\textures\turret_1.bmp");
            GenerateTexture(7, @"..\..\textures\wheel_1.bmp");
            GenerateTexture(8, @"..\..\textures\wheel_axle.bmp");
            GenerateTexture(9, @"..\..\textures\wheel_axle_1.bmp");
            GenerateTexture(10, @"..\..\textures\wheel_2.bmp");
            GenerateTexture(11, @"..\..\textures\wheel_axle_2.bmp");
            GenerateTexture(12, @"..\..\textures\wheel_3.bmp");
            GenerateTexture(13, @"..\..\textures\wheel_4.bmp");
            GenerateTexture(14, @"..\..\textures\box.bmp");
            GenerateTexture(15, @"..\..\textures\turret_2.bmp");
            GenerateTexture(16, @"..\..\textures\gun.bmp");
            GenerateTexture(17, @"..\..\textures\muzzle_brake.bmp");
            GenerateTexture(18, @"..\..\textures\muzzle_brake_1.bmp");
        }

        private void GenerateTexture(int idTexture, string filePath)
        {
            var gl = openGLControl1.OpenGL;
            var textureImage = new Bitmap(filePath);
            var rect = new Rectangle(0, 0, textureImage.Width, textureImage.Height);
            var pixels = textureImage.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb).Scan0;

            gl.BindTexture(OpenGL.GL_TEXTURE_2D, textures[idTexture]);

            gl.TexImage2D(OpenGL.GL_TEXTURE_2D, 0, OpenGL.GL_RGB, textureImage.Width, textureImage.Height,
                0, OpenGL.GL_BGR, OpenGL.GL_UNSIGNED_BYTE, pixels);

            gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MIN_FILTER, OpenGL.GL_LINEAR);
            gl.TexParameter(OpenGL.GL_TEXTURE_2D, OpenGL.GL_TEXTURE_MAG_FILTER, OpenGL.GL_LINEAR);
        }

        float rotation = 0;

        private void OpenGLControl1_OpenGLDraw(object sender, RenderEventArgs e)
        {
            var gl = openGLControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            var tank = new DrawTank();
            tank.DrawAllParts(gl);

            gl.Flush();

            rotation += 1.8f;
        }

        private void OpenGLControl_Resized(object sender, EventArgs e)
        {
            var gl = openGLControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            gl.LoadIdentity();
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            gl.LookAt(0, 1.5, 3, 0, 1, 0, 0, 1, 0);

            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    }
}