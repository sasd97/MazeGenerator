using Maze.Constants;
using Maze.Models;
using Maze.Service;

namespace Maze.Utils
{
    class OptionsUtils
    {

        private CellModel[,] _maze;
        private readonly int _height;
        private readonly int _width;

        private readonly bool _isCustomStart;

        private readonly int[] _customStart;

        private readonly bool _isCustomFinish;

        private readonly int[] _customFinish;

        private OptionsUtils(Builder builder) {
            _height = builder._height;
            _width = builder._width;
            _isCustomStart = builder._isCustomStart;
            _isCustomFinish = builder._isCustomFinish;
            _customStart = builder._customStartCoordinates;
            _customFinish = builder._customFinishCoordinates;
            _maze = MazeUtils.GenerateEmptyMaze(_height, _width);
            _maze = MazeService.GenerateMaze(_maze, _width, _height, _isCustomStart, _isCustomFinish, _customStart, _customFinish);
        }

        public static Builder StartConfig() {
            return new Builder();
        }

        public CellModel[,] Create() {
            return _maze;
        }

        public class Builder {

            internal int _height;
            internal int _width;

            internal bool _isCustomStart = false;

            internal int[] _customStartCoordinates = {MazeConstants.StartPosition, MazeConstants.StartPosition};

            internal int[] _customFinishCoordinates;

            internal bool _isCustomFinish = false;
        
            public Builder Height(int height) {
                this._height = height % 2 == 0 ? ++height : height;
                return this;
            }

            public Builder Width(int width) {
                this._width = width % 2 == 0 ? ++width : width;
                return this;
            }

            public Builder CustomStartCoordinates(int[] customStartCoordinates) {
                if (customStartCoordinates.Length != 2) return this;
                this._isCustomStart = true;
                this._customStartCoordinates = customStartCoordinates;
                return this;
            }

            public Builder CustomFinishCoordinates(int[] customFinishCoordinates) {
                if (customFinishCoordinates.Length != 2) return this;
                this._isCustomFinish = true;
                this._customFinishCoordinates = customFinishCoordinates;
                return this;
            }

            public OptionsUtils EndConfig() {
                return new OptionsUtils(this);
            }
        }
    }
}