using System;
using Xunit;
using Bve5_Parsing.MapGrammar;
using System.Collections.Generic;
using System.Collections;

namespace Bve5_ParsingTests
{
    /// <summary>
    /// �}�b�v�\���̃e�X�g�f�[�^
    /// </summary>
    public class MapGrammarTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "BveTs Map 2.02", new MapData() { Version = "2.02" } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    /// <summary>
    /// �}�b�v�\���̃e�X�g
    /// </summary>
    public class MapGrammarTests
    {
        /// <summary>
        /// �����ɗ^����ꂽ�\����������p�[�X���܂��B
        /// </summary>
        /// <param name="input">�}�b�v�\��</param>
        /// <returns>MapData</returns>
        private MapData ExecParse(string input)
        {
            var mParser = new MapGrammarParser();
            MapData data = null;
            try
            {
                data = mParser.Parse(input);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message + ":" + e.StackTrace);
            }

            return data;
        }

        /// <summary>
        /// Assert.NotNull��Assert.Equal�����s���܂��B
        /// </summary>
        /// <param name="expected">�p�[�T�ɂ���Đ������ꂽMapData</param>
        /// <param name="actual">�m�F�p</param>
        private void Check(MapData expected, MapData actual)
        {
            Assert.NotNull(expected);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RootTest()
        {
            Check(
                ExecParse($@"
BveTs Map 2.02
"),
                new MapData() { Version = "2.02" });
            Check(
                ExecParse($@"
BveTs Map 2.02 :utf-8
"),
                new MapData() { Version = "2.02", Encoding = "utf-8" });
            Check(
                ExecParse($@"
BveTs Map 2.02 :utf-8

"),
                new MapData() { Version = "2.02", Encoding = "utf-8" });
        }
    }
}
