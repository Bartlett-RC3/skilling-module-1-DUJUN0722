using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using SpatialSlur;

namespace RC3
{
    /// <summary>
    /// 
    /// </summary>
    public class ModelManager : MonoBehaviour
    {
        [SerializeField] private ModelInitializer _initializer;
        [SerializeField] private Cell _cellPrefab;
        [SerializeField] private int _countX = 10;
        [SerializeField] private int _countY = 10;

        private Cell[,] _cells;
        private GameOfLife2D _model;
        private int _stepCount;

        private List<Cell> _cellList = new List<Cell>();
        private List<List<Cell>> _frameList = new List<List<Cell>>();


        private IEnumerator coroutine;

        /// <summary>
        /// 
        /// </summary>
        private void Start()
        {
            // create cell array
            _cells = new Cell[_countY, _countX];

            // instantiate cell prefabs and store in array
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                {
                    Cell cell = Instantiate(_cellPrefab, transform);
                    cell.transform.localPosition = new Vector3(x, y, 0);
                    _cells[y, x] = cell;
                }
            }

            // create model
            _model = new GameOfLife2D(_countY, _countX);

            // initialize model
            _initializer.Initialize(_model.CurrentState);

            coroutine = ShowAge();
            StartCoroutine(coroutine);

        }


        /// <summary>
        /// 
        /// </summary>
        private void Update()
        {
            _model.Step();
            _stepCount++;
            //Debug.Log($"{_stepCount} steps taken!");

            int[,] state = _model.CurrentState;


            // update cells based on current state of model
            for (int y = 0; y < _countY; y++)
            {
                for (int x = 0; x < _countX; x++)
                {
                    if (_cells[y, x].State == 1 && state[y, x] == 1)
                    {
                        _cells[y, x].Age += 1;
                    }
                    else if (_cells[y, x].State == 0 && state[y, x] == 1)
                    {
                        _cells[y, x].Age = 1;
                    }
                    else if (state[y, x] == 0)
                    {
                        _cells[y, x].Age = 0;
                    }

                    if (_cells[y, x].Age >= 5)
                    {
                        _cells[y, x].Age = 0;
                    }

                    _cells[y, x].State = state[y, x];

                    _cellList.Add(_cells[y, x]);
                    _frameList.Add(_cellList);
                }
            }
        }

        private IEnumerator ShowAge()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.0f);

                for (int y = 0; y < _countY; y++)
                {
                    for (int x = 0; x < _countX; x++)
                    {
                        int age = _cells[y, x].Age;
                        _cells[y, x].GetComponent<Renderer>().material.color = new Color(0.2f * age, 0.2f * age, 0.2f * age);
                    }
                }

                Debug.Log("coroutine done!");
            }

        }

        private void OnGUI()
        {
            if (GUI.Button(new Rect(20, 20, 200, 50), "Restart"))
            {
                _model = new GameOfLife2D(_countY, _countX);
                _initializer.Initialize(_model.CurrentState);

                for (int y = 0; y < _countY; y++)
                {
                    for (int x = 0; x < _countX; x++)
                    {
                        _cells[y, x].Age = 0;
                        _cells[y, x].GetComponent<Renderer>().material.color = Color.black;
                    }
                }
            }


            if (GUI.Button(new Rect(650, 20, 200, 50), "2,3,3,3"))
            {
                _model._rules = Rules.Rule2333;
            }

            if (GUI.Button(new Rect(650, 100, 200, 50), "3,4,3,4"))
            {
                _model._rules = Rules.Rule3434;
            }


        }




    }



}