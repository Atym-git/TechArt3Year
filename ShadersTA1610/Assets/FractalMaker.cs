using UnityEngine;

public class FractalMaker : MonoBehaviour
{
    [SerializeField]
    private ComputeShader _shader;

    private RenderTexture _outputTexture;

    private ComputeBuffer _colorBuffer;

    Color[] colorsArray = new Color[100];

    private void Start()
    {
        _outputTexture = new RenderTexture(1024, 1024, 32);
        _outputTexture.enableRandomWrite = true;
        _outputTexture.Create();

         _colorBuffer = new ComputeBuffer(colorsArray.Length, colorsArray.Length);

        _colorBuffer.SetData(colorsArray);

        int kiCalc = _shader.FindKernel("pixelCalc");

        _shader.SetBuffer(kiCalc, "colors", _colorBuffer);

        _shader.SetTexture(kiCalc, "textureOut", _outputTexture);

        _shader.Dispatch(kiCalc, 32, 32, 1);
    }

}
