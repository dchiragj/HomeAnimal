import React, { Component } from 'react';
import { Router, Route, Switch, Redirect } from 'react-router-dom';
import "./App.css"
import { createBrowserHistory } from 'history';
import routes from './routes';

const history = createBrowserHistory();

interface IProps {}

class App extends Component<IProps, any> {
  constructor(props: IProps) {
    super(props);
    this.state = {};
  }

  render() {
    const routeComponents = routes.map((r, i) => {
        return <Route key={i} {...r} />;
    });
    return (
        <Router history={history}>
          <Switch>
            {routeComponents}
            <Route render={() => <Redirect to={{ pathname: '/' }} />} />
          </Switch>
        </Router>
    );
  }
}
export default App;
