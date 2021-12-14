import * as React from "react";
interface IProps {
  keyName: string;
  value: any
}
// interface IState {
//   tab: number;
// }

export default class ListSection extends React.Component<any, IProps> {

  render() {
    const { keyName, value } = this.props;
    return (
      <div className="d-flex flex-wrap block list-group-item">
        <div className="w-25">
          <h6 className="mb-0">{keyName}: </h6>
        </div>
        <p className="mb-0">{value}</p>
      </div>
    );
  }
}