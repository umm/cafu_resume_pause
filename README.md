# cafu_resume_pause

## What

- Resume/Pause interface as IPresenter
- It requires to implement your own resume/pause logic. (timer, state, etc...)


## Requirement

* cafu_core 

## Install

```shell
yarn add "umm/cafu_resume_pause#^1.0.0"
```

## Usage

e.g. cafu_timer implementation

```
public class MyPresenter : IResumePausePresenter, ITimerPresenter
{
    public ITimerUseCase TimerUseCase { get; private set; }

    public bool IsPlaying => this.TimerUseCase.IsPlaying;

    public UniRx.IObservable<bool> IsPlayingAsObservable => this.TimerUseCase.IsPlayingAsObservable;

    public void Resume()
    {
        this.ResumeTimer();
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        this.PauseTimer();
        Time.timeScale = 0f;
    }
}
```

## License

Copyright (c) 2018 Takuma Maruyama

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)

