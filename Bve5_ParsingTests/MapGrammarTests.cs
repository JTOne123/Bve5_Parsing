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

        [Theory(DisplayName = "���[�g(�t�@�C���w�b�_��")]
        [ClassData(typeof(MapGrammarTestData))]
        public void RootTest(string input, MapData result)
        {
            var r = ExecParse(input);

            Assert.NotNull(r);
            Assert.Equal(r, result);
        }
    }
}
